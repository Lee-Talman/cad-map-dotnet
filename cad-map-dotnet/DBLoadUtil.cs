using System;
using System.Data.SqlClient;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using System.Data;

namespace cad_map_dotnet
{
    class DBLoadUtil
    {
        // Load all Line objects into the CADDB database
        public string LoadLines()
        {
            string result = "";
            SqlConnection conn = DBUtil.GetConnection();
            try
            {
                // Get the Document and Editor object
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Editor ed = doc.Editor;

                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "LINE"), 0);
                    SelectionFilter filter = new SelectionFilter(tv);

                    PromptSelectionResult ssPrompt = ed.SelectAll(filter);
                    // Check if an object is selected
                    if (ssPrompt.Status == PromptStatus.OK)
                    {
                        double startPtX = 0.0, startPtY = 0.0, endPtX = 0.0, endPtY = 0.0;
                        string layer = "", ltype = "", color = "";
                        double len = 0.0;
                        Line line = new Line();
                        SelectionSet ss = ssPrompt.Value;

                        String sql = @"INSERT INTO dbo.Lines (StartPtX, StartPtY, EndPtX, EndPtY, Layer, Color, Linetype, Length, Created)
                                       VALUES(@StartPtX, @StartPtY, @EndPtX, @EndPtY, @Layer, @Color, @Linetype, @Length, @Created)";

                        conn.Open();
                        // Loop through the selection set ss and insert into database, one LINE object at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            line = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as Line;
                            startPtX = line.StartPoint.X;
                            startPtY = line.StartPoint.Y;
                            endPtX = line.EndPoint.X;
                            endPtY = line.EndPoint.Y;
                            layer = line.Layer;
                            ltype = line.Linetype;
                            color = line.Color.ToString();
                            len = line.Length;

                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@StartPtX", startPtX);
                            cmd.Parameters.AddWithValue("@StartPtY", startPtY);
                            cmd.Parameters.AddWithValue("@EndPtX", endPtX);
                            cmd.Parameters.AddWithValue("@EndPtY", endPtY);
                            cmd.Parameters.AddWithValue("@Layer", layer);
                            cmd.Parameters.AddWithValue("@Color", color);
                            cmd.Parameters.AddWithValue("@Linetype", ltype);
                            cmd.Parameters.AddWithValue("@Length", len);
                            cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        ed.WriteMessage("No object selected.");
                    }
                    result = "Completed Succesfully.";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;

        }
        // Load all MText objects into the CADDB database
        public string LoadMTexts()
        {
            string result = "";
            SqlConnection conn = DBUtil.GetConnection();
            try
            {
                // Get the Document and Editor object
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Editor ed = doc.Editor;

                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "MTEXT"), 0);
                    SelectionFilter filter = new SelectionFilter(tv);

                    PromptSelectionResult ssPrompt = ed.SelectAll(filter);
                    // Check if an object is selected
                    if (ssPrompt.Status == PromptStatus.OK)
                    {
                        double insPtX = 0.0, insPtY = 0.0;
                        string layer = "", textstyle = "", color = "";
                        double height = 0.0, width = 0.0;
                        int attachment;
                        MText mtx = new MText();
                        string tx = "";
                        SelectionSet ss = ssPrompt.Value;

                        String sql = @"INSERT INTO dbo.MTexts (InsPtX, InsPtY, Layer, Color, TextStyle, Height, Width, Text, Attachment, Created)
                                       VALUES(@InsPtX, @InsPtY, @Layer, @Color, @TextStyle, @Height, @Width, @Text, @Attachment, @Created)";

                        conn.Open();
                        // Loop through the selection set ss and insert into database, one MTEXT object at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            mtx = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as MText;
                            insPtX = mtx.Location.X;
                            insPtY = mtx.Location.Y;
                            layer = mtx.Layer;
                            color = mtx.Color.ToString();
                            textstyle = mtx.TextStyleName;
                            height = mtx.TextHeight;
                            width = mtx.Width;
                            tx = mtx.Contents;
                            attachment = Convert.ToInt32(mtx.Attachment);

                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@InsPtX", insPtX);
                            cmd.Parameters.AddWithValue("@InsPtY", insPtY);
                            cmd.Parameters.AddWithValue("@Layer", layer);
                            cmd.Parameters.AddWithValue("@Color", color);
                            cmd.Parameters.AddWithValue("@TextStyle", textstyle);
                            cmd.Parameters.AddWithValue("@Height", height);
                            cmd.Parameters.AddWithValue("@Width", width);
                            cmd.Parameters.AddWithValue("@Text", tx);
                            cmd.Parameters.AddWithValue("@Attachment", attachment);
                            cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        ed.WriteMessage("No object selected.");
                    }
                    result = "Completed Succesfully.";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;

        }
        // Load all Polyline objects into the CADDB database
        public string LoadPolylines()
        {
            string result = "";
            SqlConnection conn = DBUtil.GetConnection();
            try
            {
                // Get the Document and Editor object
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Editor ed = doc.Editor;

                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "LWPOLYLINE"), 0);
                    SelectionFilter filter = new SelectionFilter(tv);

                    PromptSelectionResult ssPrompt = ed.SelectAll(filter);
                    // Check if an object is selected
                    if (ssPrompt.Status == PromptStatus.OK)
                    {
                        string name = "";
                        string layer = "", ltype = "";
                        string coords = "";
                        double len = 0.0;
                        Polyline pline = new Polyline();
                        bool isClosed = false;
                        SelectionSet ss = ssPrompt.Value;

                        String sql = @"INSERT INTO dbo.Plines (Name, Layer, Linetype, Length, Coordinates, IsClosed, Created)
                                       VALUES(@Name, @Layer, @Linetype, @Length, @Coordinates, @IsClosed, @Created)";

                        conn.Open();
                        // Loop through the selection set ss and insert into database, one LWPOLYLINE object at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            pline = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as Polyline;
                            name = pline.BlockName;
                            layer = pline.Layer;
                            ltype = pline.Linetype;
                            len = pline.Length;
                            coords = CommonUtil.GetPolyLineCoordinates(pline);
                            isClosed = pline.Closed;

                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Layer", layer);
                            cmd.Parameters.AddWithValue("@Linetype", ltype);
                            cmd.Parameters.AddWithValue("@Length", len);
                            cmd.Parameters.AddWithValue("@Coordinates", coords);
                            cmd.Parameters.AddWithValue("@IsClosed", isClosed);
                            cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        ed.WriteMessage("No object selected.");
                    }
                    result = "Completed Succesfully.";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;

        }
        // Load all Blocks without Attributes into the CADDB database
        public string LoadBlocksWithoutAttributes()
        {
            string result = "";
            SqlConnection conn = DBUtil.GetConnection();
            try
            {
                // Get the Document and Editor object
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Editor ed = doc.Editor;

                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "INSERT"), 0);
                    SelectionFilter filter = new SelectionFilter(tv);

                    PromptSelectionResult ssPrompt = ed.SelectAll(filter);
                    // Check if an object is selected
                    if (ssPrompt.Status == PromptStatus.OK)
                    {
                        double insPtX = 0.0, insPtY = 0.0;
                        string blkname = "";
                        string layer = "";
                        double rotation = 0.0;
                        BlockReference blk;
                        string insPt = "";
                        // string attributes = "";
                        SelectionSet ss = ssPrompt.Value;

                        String sql = @"INSERT INTO dbo.BlocksWithAttributes (InsertionPt, BlockName, ExtX, ExtY, Layer, Rotation, Created)
                                       VALUES(@InsertionPt, @BlockName, @ExtX, @ExtY, @Layer, @Rotation, @Created)";

                        conn.Open();
                        // Loop through the selection set ss and insert into database, one INSERT object at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            blk = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as BlockReference;
                            if (blk.AttributeCollection.Count == 0 & !blk.Name.Contains("*"))
                            {
                                Extents3d? bounds = blk.Bounds;
                                var ext = bounds.Value;
                                double width = ext.MaxPoint.X - ext.MinPoint.X;
                                double height = ext.MaxPoint.Y - ext.MinPoint.Y;

                                insPtX = blk.Position.X;
                                insPtY = blk.Position.Y;
                                insPt = insPtX.ToString() + "," + insPtY.ToString();
                                blkname = blk.Name;
                                layer = blk.Layer;
                                rotation = blk.Rotation;

                                SqlCommand cmd = new SqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@InsertionPt", insPt);
                                cmd.Parameters.AddWithValue("@BlockName", blkname);
                                cmd.Parameters.AddWithValue("@ExtX", width);
                                cmd.Parameters.AddWithValue("@ExtY", height);
                                cmd.Parameters.AddWithValue("@Layer", layer);
                                cmd.Parameters.AddWithValue("@Rotation", rotation);
                                cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        ed.WriteMessage("No object selected.");
                    }
                    result = "Completed Succesfully.";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;

        }
        // Load all Blocks with Attributes into the CADDB database
        public string LoadBlocksWithAttributes()
        {
            string result = "";
            SqlConnection conn = DBUtil.GetConnection();
            try
            {
                // Get the Document and Editor object
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Editor ed = doc.Editor;

                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "INSERT"), 0);
                    SelectionFilter filter = new SelectionFilter(tv);

                    PromptSelectionResult ssPrompt = ed.SelectAll(filter);
                    // Check if an object is selected
                    if (ssPrompt.Status == PromptStatus.OK)
                    {
                        double insPtX = 0.0, insPtY = 0.0;
                        string blkname = "";
                        string layer = "";
                        double rotation = 0.0, width = 0.0, height = 0.0;
                        BlockReference blk;
                        // string insPt = "";
                        string attributes = "";
                        SelectionSet ss = ssPrompt.Value;

                        // @TODO: Add back the Attributes and @Attributes here
                        String sql = @"INSERT INTO dbo.BlocksWithAttributes (InsPtX, InsPtY, BlockName, ExtX, ExtY, Layer, Rotation, Attributes, Created)
                                       VALUES(@InsPtX, @InsPtY, @BlockName, @ExtX, @ExtY, @Layer, @Rotation, @Attributes, @Created)";

                        conn.Open();
                        // Loop through the selection set ss and insert into database, one INSERT object at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            blk = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as BlockReference;
                            if (blk.AttributeCollection.Count >= 0 & !blk.Name.Contains("*"))
                            {

                                // Loop through the block attributes
                                foreach (ObjectId attRefId in blk.AttributeCollection)
                                {
                                    DBObject obj = trans.GetObject(attRefId, OpenMode.ForWrite);
                                    AttributeReference attRef = obj as AttributeReference;
                                    if (attRef != null)
                                    {
                                        attributes += attRef.Tag + "=" + attRef.TextString + ",";
                                        attRef.Erase(true);
                                    }
                                }

                                Extents3d? bounds = blk.Bounds;
                                if (bounds.HasValue)
                                {
                                    var ext = bounds.Value;
                                    width = ext.MaxPoint.X - ext.MinPoint.X;
                                    height = ext.MaxPoint.Y - ext.MinPoint.Y;
                                }
                                else
                                {
                                    width = 0.0;
                                    height = 0.0;
                                }

                                insPtX = blk.Position.X;
                                insPtY = blk.Position.Y;
                                //insPt = insPtX.ToString() + "," + insPtY.ToString();
                                blkname = blk.Name;
                                layer = blk.Layer;
                                rotation = blk.Rotation;

                                /*
                                // Loop through the block attributes
                                foreach (ObjectId attRefId in blk.AttributeCollection)
                                {
                                    DBObject obj = trans.GetObject(attRefId, OpenMode.ForRead);
                                    AttributeReference attRef = obj as AttributeReference;
                                    if (attRef != null)
                                    {
                                        attributes += attRef.Tag + "=" + attRef.TextString + ",";
                                    }
                                }
                                */

                                if (attributes.Length > 1)
                                {
                                    attributes = attributes.Substring(0, attributes.Length - 1); // remove last comma                                                                 
                                }

                                SqlCommand cmd = new SqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@InsPtX", insPtX);
                                cmd.Parameters.AddWithValue("@InsPtY", insPtY);
                                cmd.Parameters.AddWithValue("@BlockName", blkname);
                                cmd.Parameters.AddWithValue("@ExtX", width);
                                cmd.Parameters.AddWithValue("@ExtY", height);
                                cmd.Parameters.AddWithValue("@Layer", layer);
                                cmd.Parameters.AddWithValue("@Rotation", rotation);
                                cmd.Parameters.AddWithValue("@Attributes", attributes);
                                cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        ed.WriteMessage("No object selected.");
                    }
                    result = "Completed Succesfully.";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;

        }
    }
}
