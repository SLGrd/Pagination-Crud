using Common;
using Common.Models;
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
                DataTable dt = new();
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
                    cn.Open();
                    await Task.Run(() => da.Fill(dt));
                    cn.Close();
                }

                //  Move data from table to list        
                foreach (DataRow dr in dt.Rows)
                {
                    AmigoModel A = new()
                    {
                        Nome = (string)dr["Nome"],
                        Address = (string)dr["Address"],
                        Phone = (string)dr["Phone"],
                        Email = (string)dr["Email"],
                        RowId = (int)dr["RowId"]
                    };
                    Amigos.Add(A);
                }

                return Amigos;
            }
            catch (Exception) { throw; }
        }
    }

    //public class AmigoRepositoryLista : IAmigoRepositories<AmigoModel>
    //{
    //    public  List<AmigoModel> GetPage(int PageNumber, int RecsPerPage)
    //    {
    //        try
    //        {
    //            DataTable dt = new();
    //            List<AmigoModel> Amigos = new();

    //            string Sql = "Select * from Amigos Order By Nome"
    //                       + " Offset (@RecsPerPage * (@PageNumber -1)) ROWS"
    //                       + " Fetch Next @RecsPerPage ROWS ONLY ";

    //            using SqlConnection cn = new(GLB.CnnString);
    //            using SqlCommand cmd = new(Sql, cn);
    //            cmd.Parameters.Add(new SqlParameter("RecsPerPage", RecsPerPage));
    //            cmd.Parameters.Add(new SqlParameter("PageNumber", PageNumber));

    //            using SqlDataAdapter da = new(cmd);
    //            {
    //                cn.Open(); da.Fill(dt); cn.Close();
    //            }

    //            //  Move data from table to list        
    //            foreach (DataRow dr in dt.Rows)
    //            {
    //                AmigoModel A = new()
    //                {
    //                    Nome = (string)dr["Nome"],
    //                    Address = (string)dr["Address"],
    //                    Phone = (string)dr["Phone"],
    //                    Email = (string)dr["Email"],
    //                    RowId = (int)dr["RowId"]
    //                };
    //                Amigos.Add(A);
    //            }
    //            return Amigos;
    //        }
    //        catch (Exception) { throw; }
    //    }
    //}
}