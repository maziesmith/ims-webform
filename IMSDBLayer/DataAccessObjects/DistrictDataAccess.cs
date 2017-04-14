﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMSDBLayer.DataAccessInterfaces;
using IMSDBLayer.DataModels;
using IMSDBLayer.DataAccessObjects.Helpers;
using System.Data.SqlClient;

namespace IMSDBLayer.DataAccessObjects
{
    public class DistrictDataAccess : IDistrictDataAccess
    {
        private SqlExecuter<District> sqlExecuter;

        public DistrictDataAccess(string connstring)
        {
            this.sqlExecuter = new SqlExecuter<District>(connstring);
        }
        
        public District create(District district)
        {
            SqlCommand command = new SqlCommand(@"INSERT INTO Districts (Name) VALUES(@Name)");
            district.Id = (Guid)sqlExecuter.ExecuteScalar(command, district);

            if (district.Id != Guid.Empty)
                return district;
            return null;
        }
        
        public bool update(District district)
        {
            SqlCommand command = new SqlCommand(@"UPDATE Districts Set Name = @Name WHERE Id = @Id");
            return sqlExecuter.ExecuteNonQuery(command, district) > 0;
        }
        
        public IEnumerable<District> getAll()
        {
            SqlCommand command = new SqlCommand("Select * From Districts");
            return sqlExecuter.ExecuteReader(command);
        }

        public District fetchDistrictById(Guid districtId)
        {
            SqlCommand command = new SqlCommand(@"Select * From Districts WHERE Id = @Id");
            command.Parameters.AddWithValue("@Id", districtId);
            return sqlExecuter.ExecuteReader(command).FirstOrDefault();
        }
    }
}