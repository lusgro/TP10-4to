namespace TP10.Models;
using System.Data.SqlClient;
using Dapper;

public static class BD {
    private static string _connectionString { get; set; } = @"Server=PC-LUCAS\SQLEXPRESS01;DataBase=BDSeries;Trusted_Connection=True;";

    public static List<Serie> ObtenerSeries() {
        string query = "SELECT * FROM Series";
        using (SqlConnection connection = new SqlConnection(_connectionString)) {
            return connection.Query<Serie>(query).ToList();
        }
    }

    public static List<Actor> ObtenerActores(int idSerie) {
        string query = "SELECT * FROM Actores WHERE IdSerie = @IdSerie";
        using (SqlConnection connection = new SqlConnection(_connectionString)) {
            return connection.Query<Actor>(query, new {IdSerie = idSerie}).ToList();
        }
    }

    public static List<Temporada> ObtenerTemporadas(int idSerie) {
        string query = "SELECT * FROM Temporadas WHERE IdSerie = @IdSerie";
        using (SqlConnection connection = new SqlConnection(_connectionString)) {
            return connection.Query<Temporada>(query, new {IdSerie = idSerie}).ToList();
        }
    }
    
    public static Serie ObtenerInfo(int idSerie) {
        string query = "SELECT * FROM Series WHERE IdSerie = @IdSerie";
        using (SqlConnection connection = new SqlConnection(_connectionString)) {
            return connection.QueryFirstOrDefault<Serie>(query, new {IdSerie = idSerie});
        }
    }
}