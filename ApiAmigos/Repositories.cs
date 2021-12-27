using ApiAmigos.Interfaces;
using Common;
using Common.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAmigos.Repositories
{
    public class AmigoRepositoryList : Interfaces.IAmigoRepositories<AmigoModel>
    {
        public  Task< AmigoModel> CreateRow(AmigoModel a)
        {                      
            throw new NotImplementedException();
        }
        public  Task<AmigoModel> UpdateRow(AmigoModel a) 
        {                       
            throw new NotImplementedException();
        }
        public  Task<string> DeleteRow(int rowId)
        {                       
            throw new NotImplementedException();                       
        }

        public async Task<IEnumerable<AmigoModel>> GetPage(int PageNumber, int RecsPerPage)
        {
            List<AmigoModel> A = new()
            {
                new AmigoModel("Jose", "Rua Jose, 12", "Jose@abc.com", "123 456 789", 1),
                new AmigoModel("Joao", "Avenida Joao, 45", "Joao@abc.com", "969 773 232", 2),
                new AmigoModel("Maria", "Rua Maria, 654", "Maria@abc.com", "443 545 555", 3),
                new AmigoModel("Antonio", "Rua Antonio, 56", "Antonio@abc.com", "848 454 345", 4),

                new AmigoModel("Abel", "Rua Abel, 12", "Abel@abc.com", "123 456 789", 5),
                new AmigoModel("Manoel", "Avenida Manoel  II, 45", "Manoel@abc.com", "969 773 232", 6),
                new AmigoModel("Afonso", "Rua Afonso Henrique, 654", "Afonso@abc.com", "443 545 555", 7),
                new AmigoModel("Casemiro", "Rua Casemiro, 56", "Casemiro@abc.com", "848 454 345", 8)
            };

            // Now lets return the result as an IEnumerable object
            return A.OrderBy(x => x.Nome).Skip((PageNumber - 1) * RecsPerPage).Take(RecsPerPage);
        }
    }

    public class AmigoRepositorySql : Interfaces.IAmigoRepositories<AmigoModel>
    {
        public async Task<IEnumerable<AmigoModel>> GetPage(int PageNumber, int RecsPerPage)
        {
            try
            {               
                List<AmigoModel> Amigos = new();

                string Sql = "Select * from Amigos Order By Nome"
                                + " Offset (@RecsPerPage * (@PageNumber -1)) ROWS"
                                + " Fetch Next @RecsPerPage ROWS ONLY ";

                using SqlConnection cn = new(GLB.CnnString);
                using SqlCommand cmd = new(Sql, cn);
                cmd.Parameters.Add(new SqlParameter("RecsPerPage", RecsPerPage));
                cmd.Parameters.Add(new SqlParameter("PageNumber", PageNumber));

                using SqlDataAdapter da = new(cmd);
                {
                    DataTable dt = new();
                    cn.Open();
                    await Task.Run(() => da.Fill(dt));
                    cn.Close();

                    //  Move data from table to list        
                    foreach (DataRow dr in dt.Rows)
                    {
                        Amigos.Add(new()
                        {
                            Nome = (string)dr["Nome"],
                            Address = (string)dr["Address"],
                            Phone = (string)dr["Phone"],
                            Email = (string)dr["Email"],
                            RowId = (int)dr["RowId"]
                        });
                    }
                }                
                return Amigos;
            }
            catch ( Exception) { throw ; }
        }

        public async Task<AmigoModel> CreateRow(AmigoModel  a)
        {
            try{
                string Sql = "Insert into  Amigos (  Nome,   Address,  Email,  Phone ) output inserted.RowId "
                           + "             values ( @Nome,  @Address, @Email, @Phone )";

                using SqlConnection cn = new(GLB.CnnString);
                using SqlCommand cmd = new(Sql, cn);
                cmd.Parameters.Add(new SqlParameter("@Nome",    a.Nome));
                cmd.Parameters.Add(new SqlParameter("@Address", a.Address));
                cmd.Parameters.Add(new SqlParameter("@Email",   a.Email));
                cmd.Parameters.Add(new SqlParameter("@Phone",   a.Phone));                                

                cn.Open();
                a.RowId = (int)await cmd.ExecuteScalarAsync();
                cn.Close();
                
                return a;
            }
            catch ( Exception) { throw; }                       
        }

        public async Task<AmigoModel> UpdateRow(AmigoModel a)
        {
            try
            {
                string Sql = "Update  Amigos" 
                                + "       set  Nome = @Nome, Address = @Address, Email = @Email, Phone = @Phone" 
                                + "  where  RowId = @RowId";

                using SqlConnection cn = new(GLB.CnnString);
                using SqlCommand cmd = new(Sql, cn);
                cmd.Parameters.Add(new SqlParameter("@Nome",    a.Nome));
                cmd.Parameters.Add(new SqlParameter("@Address", a.Address));
                cmd.Parameters.Add(new SqlParameter("@Email",     a.Email));
                cmd.Parameters.Add(new SqlParameter("@Phone",   a.Phone));
                cmd.Parameters.Add(new SqlParameter("@RowId",    a.RowId));

                cn.Open();
                int ReturnCode = await cmd.ExecuteNonQueryAsync();
                cn.Close();

                return a;
            }
            catch (Exception) { throw; }                      
        }
        public async Task<string> DeleteRow(int rowId)
        {
            try
            {
                string Sql = "Delete from Amigos where RowId = @RowId";

                using SqlConnection cn = new(GLB.CnnString);
                using SqlCommand cmd = new(Sql, cn);
                cmd.Parameters.Add(new SqlParameter("@RowId", rowId));

                cn.Open();
                int ReturnCode = await cmd.ExecuteNonQueryAsync();
                cn.Close();

                return rowId.ToString();
            }
            catch ( Exception) { throw; }
        }
    }
}