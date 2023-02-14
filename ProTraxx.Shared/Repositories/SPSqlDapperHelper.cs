using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using static ProTraxx.Shared.Dto.Utilities.APIAppSettingsDto;

namespace ProTraxx.Shared.Repositories
{
    public class SPSqlDapperHelper : ISPSqlDapperHelper
    {
        private readonly AppSettings _appSettings;
        public SPSqlDapperHelper(IOptions<AppSettings> getAppSetting)
        {
            _appSettings = getAppSetting.Value;
        }

        public async Task<List<T>> ExecuteQuery<T, U>(string sp, U parameter)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_appSettings.ConnectionStrings.PTXTRNSDB))
                {
                    //IEnumerable<dynamic> results = conString.Query(sql: storedProcedureName, param: parameters, commandType: CommandType.StoredProcedure);
                    // var reader = conn.QueryMultiple(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
                    // var userdetails = reader.Read<userdetails>().ToList();
                    // IEnumerable<dynamic> results = await connection.QueryAsync<T>(sp, parameter, commandType: CommandType.StoredProcedure);
                    var data = await connection.QueryAsync<T>(sp, parameter, commandType: CommandType.StoredProcedure);
                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task ExecuteNonQuery<U>(string sp, U parameter)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_appSettings.ConnectionStrings.PTXTRNSDB))
                {
                    await connection.ExecuteAsync(sp, parameter, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> ExecuteSingleQuery<T, U>(string sp, U parameter)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_appSettings.ConnectionStrings.PTXTRNSDB))
                {
                    return await connection.QuerySingleOrDefaultAsync<T>(sp, parameter, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
