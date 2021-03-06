﻿using System.Collections.Generic;
using AccidentalFish.ApplicationSupport.Core.NoSql;
using Microsoft.WindowsAzure.Storage.Table;

namespace AccidentalFish.ApplicationSupport.Azure.NoSql
{
    interface ITableStorageQueryBuilder
    {
        TableQuery<T> TableQuery<T>(Dictionary<string, object> columnValues, NoSqlQueryOperator op) where T : NoSqlEntity;
        TableQuery<T> TableQuery<T>(string column, IEnumerable<object> values, NoSqlQueryOperator op) where T : NoSqlEntity;
    }
}
