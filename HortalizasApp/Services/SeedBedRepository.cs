using Dapper;
using HortalizasApp.Models;
using MySqlConnector;

namespace HortalizasApp.Services;

public interface IBedRepository
{
    Task<IEnumerable<SeedBed>> GetBeds(); 
}

public class BedRepository: IBedRepository
{
    private readonly string _connectionString;
    
    public BedRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }
                         
    public async Task<IEnumerable<SeedBed>> GetBeds()
    {
        var connection = new MySqlConnection(_connectionString);
        await connection.OpenAsync();

        return await connection.QueryAsync<SeedBed>(
            @"SELECT * FROM cama1");
    }
}