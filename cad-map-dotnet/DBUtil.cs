using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace cad_map_dotnet

{
    public static class DBUtil
        // Create connection to SQL Server DB
    {
        [CommandMethod("CADMAP")]
        public static void DBRun()
        {
            Main main = new Main();
            main.ShowDialog();
        }
        public static SqlConnection GetConnection()
        {
            string connStr = Settings1.Default.connstr;
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }
    }
}





/*
using AcAp = Autodesk.AutoCAD.ApplicationServices.Core.Application;


[assembly: CommandClass(typeof(GetAllObjectsInDatabase.CADMAP))]

namespace GetAllObjectsInDatabase
{
    public class CADMAP
    {
        [CommandMethod("CADMAP-OBJECTS")]
        public static void Test1()
        {
            var doc = AcAp.DocumentManager.MdiActiveDocument;
            var db = doc.Database;
            var ed = doc.Editor;
            foreach (var item in GetAllObjects(db))
            {
                ed.WriteMessage($"\n{item.Key.Handle,-6} {item.Value}");
            }
        }


        [CommandMethod("CADMAP-ENTITIES")]
        public static void Test2()
        {
            var doc = AcAp.DocumentManager.MdiActiveDocument;
            var db = doc.Database;
            var ed = doc.Editor;
            foreach (var item in GetAllEntities(db))
            {
                ed.WriteMessage($"\n{item.Key.Handle,-6} {item.Value}");
            }
        }

        static Dictionary<ObjectId, string> GetAllObjects(Database db)
        {
            var dict = new Dictionary<ObjectId, string>();
            for (long i = db.BlockTableId.Handle.Value; i < db.Handseed.Value; i++)
            {
                if (db.TryGetObjectId(new Handle(i), out ObjectId id))
                    dict.Add(id, id.ObjectClass.Name);
            }
            return dict;
        }

        static Dictionary<ObjectId, string> GetAllEntities(Database db)
        {
            var dict = new Dictionary<ObjectId, string>();
            using (var tr = db.TransactionManager.StartOpenCloseTransaction())
            {
                var bt = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                foreach (var btrId in bt)
                {
                    var btr = (BlockTableRecord)tr.GetObject(btrId, OpenMode.ForRead);
                    if (btr.IsLayout)
                    {
                        foreach (var id in btr)
                        {
                            dict.Add(id, id.ObjectClass.Name);
                        }
                    }
                }
                tr.Commit();
            }
            return dict;
        }
    }
}
*/