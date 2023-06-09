﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DatabaseLayer
{
    public class DBLayer
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);

        public List<ElevData> GetAllElevDataFromElevByJoin()
        {
            try
            {
                List<ElevData> ElevData = new List<ElevData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Fornavn, Etternavn, Adresse, Poststeder.PostNr, Poststed, Fagnavn, Klassenavn FROM Elev INNER JOIN FagElev ON FagElev.ElevID = Elev.ElevID INNER JOIN Fag ON Fag.FagKode = FagElev.FagKode INNER JOIN Klasse ON Klasse.KlasseID = Elev.KlasseID INNER JOIN Poststeder ON Poststeder.PostNr = Elev.PostNr ORDER BY Fornavn", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ElevData ed = new ElevData();
                    ed.Fornavn = (string)reader["Fornavn"];
                    ed.Etternavn = (string)reader["Etternavn"];
                    ed.Adresse = (string)reader["Adresse"];
                    ed.PostNr = (int)reader["PostNr"];
                    ed.Poststed = (string)reader["Poststed"];
                    ed.Klassenavn = (string)reader["Klassenavn"];
                    ed.Fagnavn = (string)reader["Fagnavn"];
                    ElevData.Add(ed);
                }
                reader.Close();
                conn.Close();

                return ElevData;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<ElevData> GetAllElevDataWhereFornavn(string Fornavn)
        {
            try
            {
                List<ElevData> ElevData = new List<ElevData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Fornavn, Etternavn, Adresse, Poststeder.PostNr, Poststed, Fagnavn, Klassenavn FROM Elev INNER JOIN FagElev ON FagElev.ElevID = Elev.ElevID INNER JOIN Fag ON Fag.FagKode = FagElev.FagKode INNER JOIN Klasse ON Klasse.KlasseID = Elev.KlasseID INNER JOIN Poststeder ON Poststeder.PostNr = Elev.PostNr WHERE Fornavn = @fn", conn);

                cmd.Parameters.AddWithValue("fn", Fornavn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ElevData ed = new ElevData();
                    ed.Fornavn = (string)reader["Fornavn"];
                    ed.Etternavn = (string)reader["Etternavn"];
                    ed.Adresse = (string)reader["Adresse"];
                    ed.PostNr = (int)reader["PostNr"];
                    ed.Poststed = (string)reader["Poststed"];
                    ed.Klassenavn = (string)reader["Klassenavn"];
                    ed.Fagnavn = (string)reader["Fagnavn"];
                    ElevData.Add(ed);
                }
                reader.Close();
                conn.Close();

                return ElevData;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<ElevData> GetAllElevDataWhereKlassenavn(string Klassenavn)
        {
            try
            {
                List<ElevData> ElevData = new List<ElevData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Fornavn, Etternavn, Adresse, Poststeder.PostNr, Poststed, Fagnavn, Klassenavn FROM Elev INNER JOIN FagElev ON FagElev.ElevID = Elev.ElevID INNER JOIN Fag ON Fag.FagKode = FagElev.FagKode INNER JOIN Klasse ON Klasse.KlasseID = Elev.KlasseID INNER JOIN Poststeder ON Poststeder.PostNr = Elev.PostNr WHERE Klassenavn = @kn ORDER BY Fornavn", conn);

                cmd.Parameters.AddWithValue("kn", Klassenavn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ElevData ed = new ElevData();
                    ed.Fornavn = (string)reader["Fornavn"];
                    ed.Etternavn = (string)reader["Etternavn"];
                    ed.Adresse = (string)reader["Adresse"];
                    ed.PostNr = (int)reader["PostNr"];
                    ed.Poststed = (string)reader["Poststed"];
                    ed.Klassenavn = (string)reader["Klassenavn"];
                    ed.Fagnavn = (string)reader["Fagnavn"];
                    ElevData.Add(ed);
                }
                reader.Close();
                conn.Close();

                return ElevData;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<ElevData> GetAllElevDataWhereFagnavn(string Fagnavn)
        {
            try
            {
                List<ElevData> ElevData = new List<ElevData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Fornavn, Etternavn, Adresse, Poststeder.PostNr, Poststed, Fagnavn, Klassenavn FROM Elev INNER JOIN FagElev ON FagElev.ElevID = Elev.ElevID INNER JOIN Fag ON Fag.FagKode = FagElev.FagKode INNER JOIN Klasse ON Klasse.KlasseID = Elev.KlasseID INNER JOIN Poststeder ON Poststeder.PostNr = Elev.PostNr WHERE Fagnavn = @fn ORDER BY Fornavn", conn);

                cmd.Parameters.AddWithValue("fn", Fagnavn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ElevData ed = new ElevData();
                    ed.Fornavn = (string)reader["Fornavn"];
                    ed.Etternavn = (string)reader["Etternavn"];
                    ed.Adresse = (string)reader["Adresse"];
                    ed.PostNr = (int)reader["PostNr"];
                    ed.Poststed = (string)reader["Poststed"];
                    ed.Klassenavn = (string)reader["Klassenavn"];
                    ed.Fagnavn = (string)reader["Fagnavn"];
                    ElevData.Add(ed);
                }
                reader.Close();
                conn.Close();

                return ElevData;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<ElevData> GetCountByKlasseNavn1A()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            List<ElevData> ElevData = new List<ElevData>();
            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Fornavn FROM Elev, Klasse WHERE Elev.KlasseID = 1 AND Elev.KlasseID = Klasse.KlasseID", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ElevData ed = new ElevData();
                    ed.Fornavn = (string)reader["Fornavn"];
                    ElevData.Add(ed);
                }

                reader.Close();
                conn.Close();
            }
            return ElevData;
        }

        public List<ElevData> GetCountByKlasseNavn1B()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            List<ElevData> ElevData = new List<ElevData>();
            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Fornavn FROM Elev, Klasse WHERE Elev.KlasseID = 2 AND Elev.KlasseID = Klasse.KlasseID", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ElevData ed = new ElevData();
                    ed.Fornavn = (string)reader["Fornavn"];
                    ElevData.Add(ed);
                }

                reader.Close();
                conn.Close();
            }
            return ElevData;
        }

        public List<ElevData> GetTeacherData()
        {
            try
            {
                List<ElevData> ElevData = new List<ElevData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Lærernavn, KlasseNavn, Fagnavn FROM Lærer, Klasse, KlasseLærer, Fag, FagLærer WHERE Klasse.KlasseID = KlasseLærer.KlasseID AND Lærer.LærerID = KlasseLærer.LærerID\r\nAND FagLærer.LærerID = Lærer.LærerID AND Fag.FagKode = FagLærer.FagKode", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ElevData ed = new ElevData();
                    ed.Lærernavn = (string)reader["Lærernavn"];
                    ed.Klassenavn = (string)reader["Klassenavn"];
                    ed.Fagnavn = (string)reader["Fagnavn"];
                    ElevData.Add(ed);
                }
                reader.Close();
                conn.Close();

                return ElevData;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
