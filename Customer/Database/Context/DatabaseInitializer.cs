using Customer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Database.Context
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            
            Classification classification = new Classification();
            classification.ClassificationName = "classification 1";
            context.Classifications.Add(classification);
            classification.ClassificationName = "Classification 2";
            context.Classifications.Add(classification);
            classification.ClassificationName = "Classification 3";
            context.Classifications.Add(classification);
            classification.ClassificationName = "Classification 4";
            context.Classifications.Add(classification);
            classification.ClassificationName = "Classification 5";
            context.Classifications.Add(classification);


            ClientType clientType = new ClientType();
            clientType.ClientTypeName = "ClientType 1";
            context.Classifications.Add(classification);

            clientType.ClientTypeName = "ClientType 2";
            context.Classifications.Add(classification);

            clientType.ClientTypeName = "ClientType 3";
            context.Classifications.Add(classification);

            clientType.ClientTypeName = "ClientType 4";
            context.Classifications.Add(classification);

            clientType.ClientTypeName = "ClientType 5";
            context.Classifications.Add(classification);

            clientType.ClientTypeName = "ClientType 6";
            context.Classifications.Add(classification);
            base.Seed(context);
        }
    }
}