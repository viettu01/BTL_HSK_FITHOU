using System;
using System.Data;
using System.Data.SqlClient;

namespace TestDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String constr = @"Data Source=KING;Initial Catalog=HSK_QuanLyCuaHangBanDienThoai;Persist Security Info=True;User ID=sa;Password=123";

                int chon;
                String nameProducer;

                do
                {
                    Console.WriteLine("================ Mời bạn chọn ================");
                    Console.WriteLine("|| 1. Thêm nhà sản xuất                      ||");
                    Console.WriteLine("|| 2. Xóa nhà sản xuất                       ||");
                    Console.WriteLine("|| 3. Xem danh sách nhà sản xuất             ||");
                    Console.WriteLine("|| 4. Tìm kiếm nhà sản xuất                  ||");
                    Console.WriteLine("|| 5. Sửa tên nhà sản xuất                   ||");
                    Console.WriteLine("|| 6. Thêm điện thoại                        ||");
                    Console.WriteLine("|| 7. Xem danh sách điện thoại               ||");
                    Console.WriteLine("|| 8. Xóa điện thoại                         ||");
                    Console.WriteLine("|| 9. Tìm điện thoại theo tên                ||");
                    Console.WriteLine("|| 10. Tìm điện thoại trong khoảng giá       ||");
                    Console.WriteLine("|| 11. Sửa tên điện thoại                    ||");
                    Console.WriteLine("|| 0. Thoát                                  ||");
                    Console.WriteLine("===============================================");
                    Console.Write("Nhập lựa chọn: ");
                    chon = int.Parse(Console.ReadLine());

                    switch (chon)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            Console.Write("Nhập tên nhà sản xuất: ");
                            nameProducer = Console.ReadLine();
                            if (!checkExistsNameProducer(constr, nameProducer))
                            {
                                Console.WriteLine("Nhà sản xuất đã tồn tại");
                                break;
                            }
                            if (insertProducer(constr, nameProducer))
                            {
                                Console.WriteLine("Thêm thành công");
                            }
                            else
                            {
                                Console.WriteLine("Thêm thất bại");
                            }
                            break;
                        case 2:
                            Console.Write("Danh sách nhà sản xuất trước khi xóa: ");
                            findAllProducer(constr);

                            Console.Write("Nhập tên nhà sản xuất cần xóa: ");
                            nameProducer = Console.ReadLine();

                            if (checkExistsNameProducer(constr, nameProducer))
                            {
                                Console.WriteLine("Nhà sản xuất không tồn tại");
                                break;
                            }

                            if (Program.deleteProducerByName(constr, nameProducer))
                            {
                                Console.WriteLine("Xóa thành công");
                                Console.Write("Danh sách nhà sản xuất sau khi xóa: ");
                                findAllProducer(constr);
                            }
                            else
                                Console.WriteLine("Xóa thất bại");
                            break;
                        case 3:
                            Console.WriteLine("Danh sách nhà sản xuất");
                            findAllProducer(constr);
                            break;
                        case 4:
                            Console.Write("Nhập tên nhà sản xuất cần tìm: ");
                            nameProducer = Console.ReadLine();
                            findProducerUseDataAdapterByName(constr, nameProducer);
                            break;
                        case 5:
                            Console.WriteLine("Danh sách nhà sản xuất");
                            findAllProducer(constr);
                            Console.Write("Nhập id nhà sản xuất cần sửa: ");
                            int id = int.Parse(Console.ReadLine());
                            if (checkExistsProducerById(constr, id))
                            {
                                Console.WriteLine("Mã nhà sản xuất không tồn tại");
                                break;
                            }
                            Console.Write("Nhập tên nhà sản xuất mới: ");
                            nameProducer = Console.ReadLine();
                            if (!checkExistsNameProducer(constr, nameProducer))
                            {
                                Console.WriteLine("Nhà sản xuất đã tồn tại");
                            }
                            else
                            {
                                if (updateProducer(constr, id, nameProducer))
                                {
                                    Console.WriteLine("Chỉnh sửa thành công");
                                    Console.Write("Danh sách nhà sản xuất sau khi sửa: ");
                                    findAllProducer(constr);
                                }
                                else
                                    Console.WriteLine("Chỉnh sửa thất bại");
                            }

                            break;
                        case 6:
                            String namePhone, timeBH;
                            int idProoducer, quantitly;
                            double price;

                            Console.Write("Nhập tên điện thoại: ");
                            namePhone = Console.ReadLine();
                            Console.Write("Nhập mã nhà sản xuất: ");
                            idProoducer = int.Parse(Console.ReadLine());

                            while(checkExistsProducerById(constr, idProoducer))
                            {
                                Console.Write("Mã nhà sản xuất không tồn tại. Vui lòng nhập lại: ");
                                idProoducer = int.Parse(Console.ReadLine());
                            }

                            Console.Write("Nhập số lượng sản phẩm: ");
                            quantitly = int.Parse(Console.ReadLine());
                            Console.Write("Nhập giá điện thoại: ");
                            price = double.Parse(Console.ReadLine());
                            Console.Write("Nhập thời gian bảo hành: ");
                            timeBH = Console.ReadLine();

                            if (Program.insertPhone(constr, namePhone, idProoducer, quantitly, price, timeBH))
                                Console.WriteLine("Thêm thành công");
                            else
                                Console.WriteLine("Thêm thất bại");

                            break;
                        case 7:
                            findAllPhone(constr);
                            break;
                        case 8:
                            Console.Write("Danh sách điện thoại trước khi xóa: ");
                            findAllPhone(constr);
                            Console.Write("Nhập id điện thoại cần xóa: ");
                            int idPhone = int.Parse(Console.ReadLine());
                            if(checkExistsPhoneById(constr, idPhone))
                            {
                                Console.WriteLine("Id điện thoại không tồn tại");
                                break;
                            }
                            if(deletePhoneById(constr, idPhone))
                            {
                                Console.WriteLine("Xóa điện thoại thành công");
                                Console.Write("Danh sách điện thoại sau khi xóa: ");
                                findAllPhone(constr);
                            } 
                            else
                            {
                                Console.WriteLine("Xóa điện thoại thất bại");
                            }
                            break; 
                        case 9:
                            Console.Write("Nhập tên điện thoại cần tìm: ");
                            namePhone = Console.ReadLine();
                            findPhoneByName(constr, namePhone);
                            break;
                        case 10:
                            Console.Write("Nhập giá min: ");
                            double priceMin = double.Parse(Console.ReadLine());
                            Console.Write("Nhập giá max: ");
                            double priceMax = double.Parse(Console.ReadLine());
                            findPhoneByPrice(constr, priceMin, priceMax);
                            break;
                        case 11:
                            Console.WriteLine("Danh sách điện thoại trước khi sửa");
                            findAllPhone(constr);
                            Console.Write("Nhập id điện thoại cần sửa: ");
                            idPhone = int.Parse(Console.ReadLine());
                            if (checkExistsPhoneById(constr, idPhone))
                            {
                                Console.WriteLine("Mã điện thoại không tồn tại");
                                break;
                            }
                            Console.Write("Nhập tên điện thoại mới: ");
                            namePhone = Console.ReadLine();
                            if (!checkExistsNamePhone(constr, namePhone))
                            {
                                Console.WriteLine("Tên điện thoại đã tồn tại");
                            }
                            else
                            {
                                if (updatePhoneName(constr, idPhone, namePhone))
                                {
                                    Console.WriteLine("Chỉnh sửa thành công");
                                    Console.Write("Danh sách điện thoại sau khi sửa: ");
                                    findAllPhone(constr);
                                }
                                else
                                    Console.WriteLine("Chỉnh sửa thất bại");
                            }
                            break;
                        default:
                            break;
                    }
                } while (chon != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
        private static bool insertProducer(string constr, string name)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertProducer";
                    cmd.Parameters.AddWithValue("@name", name);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        private static bool updateProducer(string constr, int id, string name)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "updateProducer";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        private static bool deleteProducerByName(string constr, string name)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "deleteProducerByName";
                    cmd.Parameters.AddWithValue("@name", name);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        private static void findAllProducer(string constr)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblProducer", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (!rd.Read())
                        {
                            Console.WriteLine("Không có bản ghi nào");
                        }
                        else
                        {
                            Console.WriteLine("\n\tid\tname");
                            while (rd.Read())
                            {
                                Console.WriteLine("\t{0}\t{1}", rd["id"], rd["name"]);
                            }
                            Console.WriteLine("\n");
                        }
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
        }
        private static void findProducerUseDataAdapterByName(string constr, String nameProducer)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblProducer", cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable tb = new DataTable("tblProducer"))
                        {
                            ad.Fill(tb);
                            if (tb.Rows.Count == 0)
                                Console.WriteLine("Không có bản ghi nào");
                            else
                            {
                                //foreach (DataRow r in tb.Rows)
                                //    Console.WriteLine("\t{0}\t{1}", r["id"], r["name"]);
                                //DataView dv = new DataView(tb, "id = 1", "name", DataViewRowState.CurrentRows);
                                DataView dv = new DataView(tb, "name like '%" + nameProducer + "%'", "name", DataViewRowState.CurrentRows);
                                if (dv.Count == 0)
                                {
                                    Console.WriteLine("Không có kết quả nào");
                                }
                                else
                                {
                                    Console.WriteLine("\n\tCó " + dv.Count + " kết quả");
                                    Console.WriteLine("\tid\tname");
                                    foreach (DataRowView r in dv)
                                        Console.WriteLine("\t{0}\t{1}", r["id"], r["name"]);
                                    Console.WriteLine("\n");
                                }
                            }
                        }
                    }
                }
            }
        }
        private static bool checkExistsProducerById(string constr, int id)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblProducer", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (Convert.ToInt32(rd["id"]) == id)
                                return false;
                        }
                        Console.WriteLine("\n");
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
            return true;
        }
        private static bool checkExistsNameProducer(String constr, String name)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblProducer", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (rd["name"].Equals(name))
                                return false;
                        }
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
            return true;
        }

        private static bool insertPhone(string constr, String name, int idProducer, int quantily, double price, String timeBH)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertPhone";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@idProducer", idProducer);
                    cmd.Parameters.AddWithValue("@quantity", quantily);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@timeBH", timeBH);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        private static bool updatePhoneName(string constr, int id, string name)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "updatePhoneName";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        private static void findAllPhone(string constr)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM showAllPhone", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\n\tid\tphoneName\tproducerName\tquantity\tprice\t\ttimeBH");
                        while (rd.Read())
                        {
                            Console.WriteLine("\t{0}\t{1}\t{2}\t\t{3}\t\t{4}\t{5}",
                                rd["id"], rd["phoneName"], rd["producerName"], rd["quantity"], rd["price"], rd["timeBH"]);
                        }
                        Console.WriteLine("\n");
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
        }
        private static void findPhoneByName(string constr, String name)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from showAllPhone", cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable tb = new DataTable("showAllPhone"))
                        {
                            ad.Fill(tb);
                            if (tb.Rows.Count == 0)
                                Console.WriteLine("Không có bản ghi nào");
                            else
                            {
                                DataView dv = new DataView(tb, "phoneName like '%" + name + "%'", "phoneName", DataViewRowState.CurrentRows);
                                if (dv.Count == 0)
                                {
                                    Console.WriteLine("Không có kết quả nào");
                                }
                                else
                                {
                                    Console.WriteLine("\n\tCó " + dv.Count + " kết quả");
                                    Console.WriteLine("\n\tid\tphoneName\tproducerName\tquantity\tprice\t\ttimeBH");
                                    foreach (DataRowView r in dv)
                                        Console.WriteLine("\t{0}\t{1}\t{2}\t\t{3}\t\t{4}\t{5}",
                                            r["id"], r["phoneName"], r["producerName"], r["quantity"], r["price"], r["timeBH"]);
                                    Console.WriteLine("\n");
                                }
                            }
                        }
                    }
                }
            }
        }
        //private static void findPhoneByName(string constr, String name)
        //{
        //    using (SqlConnection cnn = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SELECT * FROM showAllPhone WHERE phoneName LIKE N'%"+name+"%'", cnn))
        //        {
        //            cnn.Open();
        //            using (SqlDataReader rd = cmd.ExecuteReader())
        //            {
        //                if (!rd.Read())
        //                {
        //                    Console.WriteLine("Không có bản ghi nào");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("\n\tid\tphoneName\tproducerName\tquantity\tprice\t\ttimeBH");
        //                    while (rd.Read())
        //                    {
        //                        Console.WriteLine("\t{0}\t{1}\t{2}\t\t{3}\t\t{4}\t{5}",
        //                            rd["id"], rd["phoneName"], rd["producerName"], rd["quantity"], rd["price"], rd["timeBH"]);
        //                    }
        //                    Console.WriteLine("\n");
        //                }
        //                rd.Close();
        //            }
        //            cnn.Close();
        //        }
        //    }
        //}
        private static bool deletePhoneById(string constr, int id)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "deletePhoneById";
                    cmd.Parameters.AddWithValue("@id", id);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        private static void findPhoneByPrice(string constr, double priceMin, double priceMax)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "Select * from showAllPhone where price BETWEEN " + priceMin + " AND " + priceMax;
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\n\tid\tphoneName\tproducerName\tquantity\tprice\t\ttimeBH");
                        while (rd.Read())
                        {
                            Console.WriteLine("\t{0}\t{1}\t{2}\t\t{3}\t\t{4}\t\t{5}",
                                rd["id"], rd["phoneName"], rd["producerName"], rd["quantity"], rd["price"], rd["timeBH"]);
                        }
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
        }
        private static bool checkExistsPhoneById(string constr, int id)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from showAllPhone", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (Convert.ToInt32(rd["id"]) == id)
                                return false;
                        }
                        Console.WriteLine("\n");
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
            return true;
        }
        private static bool checkExistsNamePhone(String constr, String name)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from showAllPhone", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (rd["phoneName"].Equals(name))
                                return false;
                        }
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
            return true;
        }
    }
}