using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using PPPK_Projekt.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PPPK_Projekt.Dao
{
    public class SqlHelper
    {
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private static readonly SqlDatabase db = new SqlDatabase(cs);

        private const string ID_VOZAC = "@VozacID";
        private const string IME = "@Ime";
        private const string PREZIME = "@Prezime";

        private const string BROJ_MOBITELA = "@BrojMobitela";
        private const string BROJ_VOZACKE_DOZVOLE = "@BrojVozackeDozvole";

        private const string TIP = "@Tip";
        private const string MARKA = "@Marka";
        private const string GODINA_PROIZVODNJE = "@GodinaProizvodnje";
        private const string PRIJEDENI_KILOMETRI = "@PrijedeniKilometri";

        private const string NAREDBODAVAC = "@Naredbodavac";

        private const string BROJ_NALOGA = "@BrojNaloga";
        private const string VOZAC_ID = "@VozacID";
        private const string VOZILO_ID = "@VoziloID";
        private const string POLAZISTE = "@Polaziste";
        private const string ODREDISTE = "@Odrediste";

        private const string BROJ_DANA = "@BrojDana";
        private const string DATUM_OTVARANJA = "@DatumOtvaranja";
        private const string DATUM_ZATVARANJA = "@DatumZatvaranja";
        private const string PUTNI_NALOG_ID = "@PutniNalogID";

        private const string ID_RUTA = "@IDRuta";
        private const string SATI = "@Sati";
        private const string KOORDINATA_A = "@KoordinataA";
        private const string KOORDINATA_B = "@KoordinataB";
        private const string PROSJECNA_BRZINA = "@ProsjecnaBrzina";
        private const string POTROSENO_GORIVO = "@PotrosenoGorivo";

        internal static DataTable GetAllDatabaseData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataTable dataTable = new DataTable(nameof(PutniNalog));
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        internal static IEnumerable<PutniNalog> GetPutniNalozi()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = nameof(GetPutniNalozi);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                yield return new PutniNalog
                                (
                                    (int)dr[nameof(PutniNalog.IDPutniNalog)],
                                    dr[nameof(PutniNalog.Naredbodavac)].ToString(),
                                    (int)dr[nameof(PutniNalog.BrojNaloga)],
                                    (int)dr[nameof(PutniNalog.VozacID)],
                                    (int)dr[nameof(PutniNalog.VoziloID)],
                                    dr[nameof(PutniNalog.Polaziste)].ToString(),
                                    dr[nameof(PutniNalog.Odrediste)].ToString(),
                                    (int)dr[nameof(PutniNalog.BrojDana)],
                                    (DateTime)dr[nameof(PutniNalog.DatumOtvaranja)],
                                    dr[nameof(PutniNalog.DatumZatvaranja)] as DateTime? ?? null
                                );
                            }
                        }
                        scope.Complete();
                    }
                }
            }
        }

        internal static DataSet SelectRutaData(int RutaID)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(ID_RUTA, RutaID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet("Ruta");

                    dataAdapter.Fill(dataSet);

                    dataSet.Tables[0].TableName = nameof(Ruta);

                    return dataSet;
                }
            }
        }

        internal static Vozilo GetVozilo(int VoziloID)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = nameof(GetVozilo);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(VOZILO_ID, VoziloID);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                return new Vozilo
                                (
                                    (int)dr[nameof(Vozilo.IDVozilo)],
                                    dr[nameof(Vozilo.Tip)].ToString(),
                                    dr[nameof(Vozilo.Marka)].ToString(),
                                    (int)dr[nameof(Vozilo.GodinaProizvodnje)],
                                    (int)dr[nameof(Vozilo.PrijedeniKilometri)],
                                    (bool)dr[nameof(Vozilo.JeSlobodno)]
                                );
                            }
                        }
                        scope.Complete();
                    }
                }
                throw new Exception("Nema tog vozila");
            }
        }

        internal static int DeletePutniNalog(int idPutniNalog)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = nameof(DeletePutniNalog);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(PUTNI_NALOG_ID, idPutniNalog);
                        scope.Complete();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        internal static int AddPutniNalog(PutniNalog noviPutniNalog)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = nameof(AddPutniNalog);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(NAREDBODAVAC, noviPutniNalog.Naredbodavac);
                        cmd.Parameters.AddWithValue(BROJ_NALOGA, noviPutniNalog.BrojNaloga);
                        cmd.Parameters.AddWithValue(VOZAC_ID, noviPutniNalog.VozacID);
                        cmd.Parameters.AddWithValue(VOZILO_ID, noviPutniNalog.VoziloID);
                        cmd.Parameters.AddWithValue(POLAZISTE, noviPutniNalog.Polaziste);
                        cmd.Parameters.AddWithValue(ODREDISTE, noviPutniNalog.Odrediste);
                        cmd.Parameters.AddWithValue(BROJ_DANA, noviPutniNalog.BrojDana);
                        cmd.Parameters.AddWithValue(DATUM_OTVARANJA, noviPutniNalog.DatumOtvaranja);
                        cmd.Parameters.AddWithValue(DATUM_ZATVARANJA, (object)noviPutniNalog.DatumZatvaranja ?? DBNull.Value);
                        SqlParameter putniNalogID = new SqlParameter(PUTNI_NALOG_ID, System.Data.SqlDbType.Int)
                        {
                            Direction = System.Data.ParameterDirection.Output
                        };
                        cmd.Parameters.Add(putniNalogID);
                        cmd.ExecuteNonQuery();
                        scope.Complete();
                        return (int)(putniNalogID.Value);
                    }
                }
            }
        }

        internal static int UpdatePutniNalog(PutniNalog updPutniNalog)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = nameof(UpdatePutniNalog);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(PUTNI_NALOG_ID, updPutniNalog.IDPutniNalog);
                        cmd.Parameters.AddWithValue(NAREDBODAVAC, updPutniNalog.Naredbodavac);
                        cmd.Parameters.AddWithValue(BROJ_NALOGA, updPutniNalog.BrojNaloga);
                        cmd.Parameters.AddWithValue(VOZAC_ID, updPutniNalog.VozacID);
                        cmd.Parameters.AddWithValue(VOZILO_ID, updPutniNalog.VoziloID);
                        cmd.Parameters.AddWithValue(POLAZISTE, updPutniNalog.Polaziste);
                        cmd.Parameters.AddWithValue(ODREDISTE, updPutniNalog.Odrediste);
                        cmd.Parameters.AddWithValue(BROJ_DANA, updPutniNalog.BrojDana);
                        cmd.Parameters.AddWithValue(DATUM_OTVARANJA, updPutniNalog.DatumOtvaranja);
                        cmd.Parameters.AddWithValue(DATUM_ZATVARANJA, updPutniNalog.DatumZatvaranja);
                        scope.Complete();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        internal static IEnumerable<Vozilo> GetVozila()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = nameof(GetVozila);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                yield return new Vozilo
                                (
                                    (int)dr[nameof(Vozilo.IDVozilo)],
                                    dr[nameof(Vozilo.Tip)].ToString(),
                                    dr[nameof(Vozilo.Marka)].ToString(),
                                    (int)dr[nameof(Vozilo.GodinaProizvodnje)],
                                    (int)dr[nameof(Vozilo.PrijedeniKilometri)],
                                    (bool)dr[nameof(Vozilo.JeSlobodno)]
                                );
                            }
                        }
                        scope.Complete();
                    }
                }
            }
        }

        internal static int AddExampleRecords() 
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                        int result = cmd.ExecuteNonQuery();
                        scope.Complete();
                        return result;
                    }
                }
            }
        }

        private static void ShowInfoMessage(object sender, SqlInfoMessageEventArgs e, System.Windows.Forms.Label label) => label.Text = e.Message;

        internal static IEnumerable<Vozac> GetVozaci(System.Windows.Forms.Label label)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                con.FireInfoMessageEventOnUserErrors = true;
                con.InfoMessage += (s, e) => ShowInfoMessage(s, e, label);
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(GetVozaci);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Vozac
                            (
                                (int)dr[nameof(Vozac.IDVozac)],
                                dr[nameof(Vozac.Ime)].ToString(),
                                dr[nameof(Vozac.Prezime)].ToString(),
                                dr[nameof(Vozac.BrojMobitela)].ToString(),
                                dr[nameof(Vozac.BrojVozackeDozvole)].ToString()
                            );
                        }
                    }
                }
            }
        }
        internal static int AddVozac(Vozac noviVozac)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(AddVozac);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(IME, noviVozac.Ime);
                    cmd.Parameters.AddWithValue(PREZIME, noviVozac.Prezime);
                    cmd.Parameters.AddWithValue(BROJ_MOBITELA, noviVozac.BrojMobitela);
                    cmd.Parameters.AddWithValue(BROJ_VOZACKE_DOZVOLE, noviVozac.BrojVozackeDozvole);
                    SqlParameter idVozac = new SqlParameter(ID_VOZAC, System.Data.SqlDbType.Int)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    cmd.Parameters.Add(idVozac);
                    cmd.ExecuteNonQuery();
                    return (int)(idVozac.Value);
                }
            }
        }
        internal static void AddVozilo(Vozilo vozilo)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(AddVozilo);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(TIP, vozilo.Tip);
                    cmd.Parameters.AddWithValue(MARKA, vozilo.Marka);
                    cmd.Parameters.AddWithValue(GODINA_PROIZVODNJE, vozilo.GodinaProizvodnje);
                    cmd.Parameters.AddWithValue(PRIJEDENI_KILOMETRI, vozilo.PrijedeniKilometri);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal static int DeleteVozac(int IDVozac)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(DeleteVozac);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(ID_VOZAC, IDVozac);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        internal static int UpdateVozac(Vozac vozac)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(UpdateVozac);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(ID_VOZAC, vozac.IDVozac);
                    cmd.Parameters.AddWithValue(IME, vozac.Ime);
                    cmd.Parameters.AddWithValue(PREZIME, vozac.Prezime);
                    cmd.Parameters.AddWithValue(BROJ_MOBITELA, vozac.BrojMobitela);
                    cmd.Parameters.AddWithValue(BROJ_VOZACKE_DOZVOLE, vozac.BrojVozackeDozvole);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        internal static int AddRuta(Ruta ruta)
        => db.ExecuteNonQuery(MethodBase.GetCurrentMethod().Name,
                ruta.Sati, ruta.KoordinataA, ruta.KoordinataB, ruta.PutniNalogID,
                ruta.PrijedeniKilometri, ruta.ProsjecnaBrzina, ruta.PotrosenoGorivo);

        internal static int UpdateRuta(Ruta ruta)
        => db.ExecuteNonQuery(MethodBase.GetCurrentMethod().Name, ruta.IDRuta,
                ruta.Sati, ruta.KoordinataA, ruta.KoordinataB, ruta.PutniNalogID,
                ruta.PrijedeniKilometri, ruta.ProsjecnaBrzina, ruta.PotrosenoGorivo);

        internal static int DeleteRuta(int IDRuta)
        => db.ExecuteNonQuery(MethodBase.GetCurrentMethod().Name, IDRuta);

        internal static void CleanDB()
        => db.ExecuteNonQuery(MethodBase.GetCurrentMethod().Name);

        internal static IList<Ruta> GetPutniNalogRute(int PutniNalogID)
        {
            IList<Ruta> rute = new List<Ruta>();

            using (IDataReader dr = db.ExecuteReader(MethodBase.GetCurrentMethod().Name, PutniNalogID))
            {
                while (dr.Read())
                {
                    rute.Add(new Ruta
                    {
                        IDRuta = (int)dr[nameof(Ruta.IDRuta)],
                        Sati = (int)dr[nameof(Ruta.Sati)],
                        KoordinataA = (double)dr[nameof(Ruta.KoordinataA)],
                        KoordinataB = (double)dr[nameof(Ruta.KoordinataB)],
                        PutniNalogID = (int)dr[nameof(Ruta.PutniNalogID)],
                        PrijedeniKilometri = (int)dr[nameof(Ruta.PrijedeniKilometri)],
                        ProsjecnaBrzina = (int)dr[nameof(Ruta.ProsjecnaBrzina)],
                        PotrosenoGorivo = (double)dr[nameof(Ruta.PotrosenoGorivo)]
                    });
                }
            }
            return rute;
        }

    }
}
