//using MongoDB.Bson;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace WindowsFormsApplication
//{
//     internal class GeoJSON : Connection
//    {
//        public static Regex spaces = new Regex(@"\s+");
//        public static Regex alphNum = new Regex(@"[^\w\s]");
//        private List<ukgeoJsonResults> mongoList = new List<ukgeoJsonResults>();
//        private DataTable dt = new DataTable();
//        private DataTable dd = new DataTable();

//        private DataTable dt1 = new DataTable();
//        public static List<string> listSea = new List<string>();

//        private DataTable dt2 = new DataTable();

//        public GeoJSON()
//        {
//            dt.Columns.Add("id");
//            dt.Columns.Add("name");
//            dt.Columns.Add("postcode");
//            dt.Columns.Add("lat");
//            dt.Columns.Add("lng");
//            dt.Columns.Add("sea");

//            dd.Columns.Add("id");
//            dd.Columns.Add("name");
//            dd.Columns.Add("postcode");
//            dd.Columns.Add("lat");
//            dd.Columns.Add("lng");
//            dd.Columns.Add("sea");

//            dt1.Columns.Add("name");
//            dt1.Columns.Add("postcode");
//            dt1.Columns.Add("lat");
//            dt1.Columns.Add("lng");

//            dt2.Columns.Add("id");
//            dt2.Columns.Add("name");
//            dt2.Columns.Add("postcode");
//            dt2.Columns.Add("lat");
//            dt2.Columns.Add("lng");
//        }

//        public void GeoJsonCacheUpdate(string json)
//        {
//            try
//            {
//                dt2.Rows.Clear();
//                if (json.Length >= 2)
//                {
//                    Main.MainInstance.CacheUpdatePlaces.autocompleteMenu1.AutoPopup = true;
//                    Main.MainInstance.CacheUpdatePlaces.autocompleteMenu1.Items = new string[0];

//                    var columnWidth = new int[] { 480 };

//                    if (databaseLite == null)
//                    {
//                    }
//                    else
//                    {
//                        var result = CollectionCache.Find(((x => x.name.StartsWith(json) || x.postcode.StartsWith(json))), limit: 7);
//                        if (result.Count() != 0)
//                        {
//                            foreach (var doc in result)
//                            {
//                                Main.MainInstance.CacheUpdatePlaces.autocompleteMenu1.AddItem(
//                                                   new MulticolumnAutocompleteItem(new[] { doc.name + " " + doc.postcode },
//                                                  doc.name + " " + doc.postcode + " " + doc.name + doc.postcode + " " + doc.postcode + doc.name
//                                                 , true, true) { ColumnWidth = columnWidth });
//                                dt2.Rows.Add(doc.id, alphNum.Replace(doc.name, ""), alphNum.Replace(doc.postcode, ""), doc.lat, doc.lng);
//                            }
//                        }
//                    }
//                }
//            }
//            catch
//            {
//            }
//        }

//        public void getDataCacheUpdate(string text)
//        {
//            try
//            {
//                Regex pRegex = new Regex("[A-Z]\\d{1,2}");

//                string add = text;
//                string orignaladd = add;
//                string[] addsplit = add.Split(' ');
//                string postcodeCheck = "";
//                if (addsplit.Length >= 3)
//                {
//                    postcodeCheck = addsplit[addsplit.Length - 2] + " " + addsplit[addsplit.Length - 1];
//                }
//                if (!pRegex.IsMatch(postcodeCheck))
//                    postcodeCheck = "";
//                if (addsplit.Length > 2)
//                {
//                    addsplit = addsplit.Reverse().Skip(2).Reverse().ToArray();
//                    if (postcodeCheck == "")
//                    {
//                        add = text;
//                    }
//                    else
//                        add = string.Join(" ", addsplit);
//                }
//                DataRow[] drRows1 = dt2.Select("name = '" + alphNum.Replace(add, "") + "'");
//                string id = "";
//                if (drRows1.Length > 1)
//                {
//                    drRows1 = drRows1.CopyToDataTable().Select("postcode = '" + postcodeCheck + "'");
//                }
//                if (drRows1.Length > 0)
//                {
//                    string[] addArr = orignaladd.Split(' ');
//                    string selLat = "", selLon = "", selPCode = "", selAddress = "";
//                    selPCode = addArr[addArr.Length - 2] + " " + addArr[addArr.Length - 1];
//                    if (!pRegex.IsMatch(selPCode))
//                        selPCode = "";
//                    string[] latArr = new string[2];
//                    string[] lngArr = new string[2];
//                    string[] pcodeArr = new string[2];
//                    DataRow dr = drRows1[0];

//                    if ((dr != null))
//                    {
//                        selLat = (dr["lat"] != null) ? dr["lat"].ToString() : "";
//                        selLon = (dr["lng"] != null) ? dr["lng"].ToString() : "";
//                        latArr = selLat.Split('.');
//                        lngArr = selLon.Split('.');
//                        pcodeArr = selPCode.Split(' ');
//                        id = dr["id"].ToString();
//                        selAddress = (dr["name"] != null) ? dr["name"].ToString() : "";
//                        if (pcodeArr.Contains("***"))
//                        {
//                            pcodeArr[0] = "***";
//                            selPCode = "***";
//                        }
//                    }

//                    Main.MainInstance.CacheUpdatePlaces.address.Text = selAddress;
//                    if (latArr[1].Length <= 5)
//                        Main.MainInstance.CacheUpdatePlaces.lat.Text = Convert.ToDouble(latArr[0] + '.' + latArr[1]).ToString();
//                    else
//                        Main.MainInstance.CacheUpdatePlaces.lat.Text = Convert.ToDouble(latArr[0] + '.' + latArr[1].Substring(0, 5)).ToString();
//                    if (lngArr[1].Length <= 5)
//                        Main.MainInstance.CacheUpdatePlaces.lng.Text = Convert.ToDouble(lngArr[0] + '.' + lngArr[1]).ToString();
//                    else
//                        Main.MainInstance.CacheUpdatePlaces.lng.Text = Convert.ToDouble(lngArr[0] + '.' + lngArr[1].Substring(0, 5)).ToString();

//                    Main.MainInstance.CacheUpdatePlaces.label1.Text = id;
//                    Main.MainInstance.CacheUpdatePlaces.postcode.Text = selPCode;
//                }
//                if (drRows1.Length == 0)
//                {
//                    using (var db = new LiteDB.LiteDatabase(Program.PlacesCacheFile))
//                    {
//                        string pst = "";
//                        LiteDB.Query qry = null;
//                        if (text.Contains("NPC"))
//                        {
//                            text.Replace("NPC", "");
//                            pst = "NPC";
//                            qry = LiteDB.Query.Or(LiteDB.Query.EQ("name", text), LiteDB.Query.EQ("postcode", pst));
//                        }
//                        else
//                        {
//                            qry = LiteDB.Query.EQ("name", text);
//                        }
//                        var col = db.GetCollection<ukgeoJsonResults1>("cacheFrom");
//                        qry = LiteDB.Query.Or(LiteDB.Query.EQ("name", text), LiteDB.Query.EQ("postcode", pst));
//                        col.Delete(qry);
//                    }
//                }
//            }
//            catch
//            {
//            }
//        }

//        #region Add Airports

//        public static string jason_airports(string lat, string lng)
//        {
//            string res = "";
//            try
//            {
//                Double dbllat;
//                Double dbllng;
//                if ((!Double.TryParse(lat, out dbllat)) || (!Double.TryParse(lng, out dbllng)))
//                {
//                    return "";
//                }

//                int maxdistance = 100;
//                int mindistance = 0;
//                var json_collection = database.GetCollection<BsonDocument>("ukgeojson");
//                var copy_type = " { type : 'Point' , coordinates : [ " + lng + " , " + lat + " ] } ";
//                var copy_geometry = " { $geometry : " + copy_type + ", $maxDistance : " + maxdistance +
//                                       " , $minDistance : " + mindistance + " }  ";
//                var copy_near = " { $near : " + copy_geometry + " } ";
//                var copy_loc = "{ loc : " + copy_near + "}";
//                var check_query = Query.Where(copy_loc).ToString();
//                check_query = check_query.Remove(0, 26);
//                check_query = check_query.Remove(check_query.Length - 6, 5);
//                var qdoc = new QueryDocument(BsonDocument.Parse(check_query));

//                var qdoc12 = new QueryDocument(BsonDocument.Parse(copy_loc));

//                var find = json_collection.Find(qdoc12);
//                foreach (var google in json_collection.Find(qdoc12))
//                {
//                    foreach (var search in google.Elements)
//                    {
//                        if (search.Name == "postcode")
//                        {
//                            res = search.Value.ToString();
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                ExceptionalHandler.ExceptionWriter(null, ex);
//            }
//            return res;
//        }

//        #endregion Add Airports

//        public static void jason(string lat, string lng)
//        {
//            Double dbllat;
//            Double dbllng;
//            if ((!Double.TryParse(lat, out dbllat)) || (!Double.TryParse(lng, out dbllng)))
//            {
//                return;
//            }

//            int maxdistance = 100;
//            int mindistance = 0;
//            var json_collection = database.GetCollection<BsonDocument>("ukgeojson");
//            var copy_type = " { type : 'Point' , coordinates : [ " + lng + " , " + lat + " ] } ";
//            var copy_geometry = " { $geometry : " + copy_type + ", $maxDistance : " + maxdistance +
//                                   " , $minDistance : " + mindistance + " }  ";
//            var copy_near = " { $near : " + copy_geometry + " } ";
//            var copy_loc = "{ loc : " + copy_near + "}";
//            var check_query = Query.Where(copy_loc).ToString();
//            check_query = check_query.Remove(0, 26);
//            check_query = check_query.Remove(check_query.Length - 6, 5);
//            var qdoc = new QueryDocument(BsonDocument.Parse(check_query));

//            var qdoc12 = new QueryDocument(BsonDocument.Parse(copy_loc));

//            var find = json_collection.Find(qdoc12);
//            foreach (var google in json_collection.Find(qdoc12))
//            {
//                foreach (var search in google.Elements)
//                {
//                    if (search.Name == "postcode")
//                    {
//                        Main.MainInstance.l4 = search.Value.ToString();
//                    }
//                }
//            }
//        }

//        #region // Cache place data

//        public static int VarCache = 0;
//        public static int farr = 0;

//        public void GeoJsonQuery(string json)
//        {
//            try
//            {
//                dt1.Rows.Clear();

//                if (json.Length >= 1)
//                {
//                    Main.MainInstance.autocompleteMenuAdd.AutoPopup = true;
//                    Main.MainInstance.autocompleteMenuAdd.Items = new string[0];

//                    var columnWidth = new int[] { 480 };

//                    ukgeoJsonResults1 objuk1 = new ukgeoJsonResults1();

//                    if (databaseLite == null)
//                    {
//                    }
//                    else
//                    {
//                        var result = CollectionCache.Find((x => x.name.StartsWith(json) || x.postcode.StartsWith(json)), limit: 7);
//                        if (result.Count() != 0)
//                        {
//                            foreach (var doc in result)
//                            {
//                                VarCache = result.Count();

//                                Main.MainInstance.autocompleteMenuAdd.AddItem(
//                                                   new MulticolumnAutocompleteItem(new[] { doc.name + " " + doc.postcode },
//                                                  doc.name + " " + doc.postcode + " " + doc.name + doc.postcode + " " + doc.postcode + doc.name
//                                                 , true, true) { ColumnWidth = columnWidth });
//                                dt1.Rows.Add(alphNum.Replace(doc.name, ""), alphNum.Replace(doc.postcode, ""), doc.lat, doc.lng);
//                            }
//                            Main.MainInstance.google = 0;
//                            Main.MainInstance.osrm = 0;
//                            Main.MainInstance.CacheVar = 1;
//                            Main.MainInstance.GoogleVar = 0;
//                            Main.MainInstance.UkjsonVar = 0;
//                        }
//                        else
//                        {
//                            Main.MainInstance.CacheVar = 0;
//                            Main.MainInstance.GoogleVar = 1;
//                            Main.MainInstance.UkjsonVar = 0;
//                        }
//                    }
//                }
//            }
//            catch
//            {
//            }
//        }

//        #endregion // Cache place data

//        public void AvoidAreasCacheGet()
//        {
//            try
//            {
//                AvoidAreasCache objAvoid = new AvoidAreasCache();
//                if (databaseLiteAreas == null)
//                {
//                }
//                else
//                {
//                    string ofc = Program.officeAbb.ToString();
//                    var result = CollectionAreasCache.FindAll();// (x => (x.office == ofc));
//                    if (result.Count() != 0)
//                    {
//                        foreach (var doc in result)
//                        {
//                            MapPoint.Location[] objLoc = new MapPoint.Location[1];

//                            objLoc[0] = Main.MainInstance.objMap.GetLocation(Convert.ToDouble(doc.lattitude), Convert.ToDouble(doc.longitude), 3);//51.420964, -0.067160, 3);
//                            objLoc[0].GoTo();

//                            Main.MainInstance.RAvoid = Main.MainInstance.objMap.Shapes.AddShape(MapPoint.GeoAutoShapeType.geoShapeRectangle, objLoc[0], doc.width, doc.height);
//                            Main.MainInstance.RAvoid.Name = doc.name.ToString();
//                            Main.MainInstance.RAvoid.Avoided = true;
//                            Main.MainInstance.RAvoid.SizeVisible = false;
//                            Main.MainInstance.RAvoid.Text = doc.name.ToString();
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                ExceptionalHandler.ExceptionWriter(null, ex);
//            }
//        }

//        public async void GeoJsonQuery(string json_collectionName, string FieldName, string FromLarge, string whoami)
//        {
//            ukgeoJsonResults objuk = new ukgeoJsonResults();
//            var json_col = database.GetCollection<ukgeoJsonResults>(json_collectionName);
//            try
//            {
//                string compStr = spaces.Replace(FromLarge, "");
//                if (!compStr.Contains("***"))
//                {
//                    var pre_query = Query.And(Query.Matches("sea", "/^" + spaces.Replace(FromLarge, "") + ".*/"), Query.Exists("name"), Query.Exists("postcode")).ToString();//,Query.EQ("cat",0.0)
//                    if (Program.catZero == true)
//                    {
//                        pre_query = Query.And(Query.Matches("sea", "/^" + spaces.Replace(FromLarge, "") + ".*/"), Query.Exists("name"), Query.Exists("postcode"), Query.EQ("cat", 0.0)).ToString();
//                    }
//                    else
//                    {
//                        pre_query = Query.And(Query.Matches("sea", "/^" + spaces.Replace(FromLarge, "") + ".*/"), Query.Exists("name"), Query.Exists("postcode")).ToString();//,Query.EQ("cat",0.0)
//                    }

//                    var qdoc2 = new QueryDocument(BsonDocument.Parse(pre_query));
//                    Main.MainInstance.autocompleteMenuAdd.Items = new string[0];
//                    IMongoSortBy sort = SortBy.Descending("officePriority." + Program.officeAbb);

//                    mongoList = json_col.Find(qdoc2).SetLimit(15).SetSortOrder(sort).SetFields("_id", "name", "postcode",
//                    "loc", "cat", "sea").ToList();

//                    var columnWidth = new int[] { 480 };
//                    dt.Rows.Clear();
//                    foreach (var doc in mongoList)
//                    {
//                        double imgIndex = (double)doc.cat;
//                        int newImgIndex = (int)imgIndex;

//                        if (whoami == "main")
//                        {
//                            Main.MainInstance.autocompleteMenuAdd.AddItem(
//                                   new MulticolumnAutocompleteItem(new[] { doc.name + " " + doc.postcode },
//                                     doc.sea[0] + " " + doc.sea[1] + " " + doc.sea[2] + " " + doc.sea[3]
//                                     , true, true) { ColumnWidth = columnWidth, ImageIndex = newImgIndex });
//                        }//mongoList
//                        dt.Rows.Add(doc._id, alphNum.Replace(doc.name, ""), alphNum.Replace(doc.postcode, ""), doc.loc.coordinates[1], doc.loc.coordinates[0], alphNum.Replace(doc.name, "") + " " + alphNum.Replace(doc.postcode, ""));
//                    }
//                    if (dt.Rows.Count == 0)
//                    {
//                        Main.MainInstance.google = 1;
//                        Main.MainInstance.osrm = 0;
//                    }
//                    else
//                    {
//                        Main.MainInstance.osrm = 1;
//                        Main.MainInstance.google = 0;
//                    }
//                }
//            }
//            catch
//            {
//            }
//        }

//        public async void GeoJsonQueryDB(string json_collectionName, string FieldName, string FromLarge, string whoami)
//        {
//            ukgeoJsonResults objuk = new ukgeoJsonResults();
//            var json_col = database.GetCollection<ukgeoJsonResults>(json_collectionName);
//            try
//            {
//                string compStr = spaces.Replace(FromLarge, "");
//                if (!compStr.Contains("***"))
//                {
//                    var pre_query = Query.And(Query.Matches("sea", "/^" + spaces.Replace(FromLarge, "") + ".*/"), Query.Exists("name"), Query.Exists("postcode")).ToString();//,Query.EQ("cat",0.0)
//                    if (Program.catZero == true)
//                    {
//                        pre_query = Query.And(Query.Matches("sea", "/^" + spaces.Replace(FromLarge, "") + ".*/"), Query.Exists("name"), Query.Exists("postcode"), Query.EQ("cat", 0.0)).ToString();
//                    }
//                    else
//                    {
//                        pre_query = Query.And(Query.Matches("sea", "/^" + spaces.Replace(FromLarge, "") + ".*/"), Query.Exists("name"), Query.Exists("postcode")).ToString();//,Query.EQ("cat",0.0)
//                    }

//                    var qdoc2 = new QueryDocument(BsonDocument.Parse(pre_query));
//                    Main.MainInstance.objplac.autocompleteMenu1.Items = new string[0];
//                    IMongoSortBy sort = SortBy.Descending("officePriority." + Program.officeAbb);

//                    mongoList = json_col.Find(qdoc2).SetLimit(15).SetSortOrder(sort).SetFields("_id", "name", "postcode",
//                    "loc", "cat", "sea").ToList();

//                    var columnWidth = new int[] { 480 };
//                    dd.Rows.Clear();
//                    foreach (var doc in mongoList)
//                    {
//                        double imgIndex = (double)doc.cat;
//                        int newImgIndex = (int)imgIndex;

//                        if (whoami == "main")
//                        {
//                            Main.MainInstance.objplac.autocompleteMenu1.AddItem(
//                                   new MulticolumnAutocompleteItem(new[] { doc.name + " " + doc.postcode },
//                                     doc.sea[0] + " " + doc.sea[1] + " " + doc.sea[2] + " " + doc.sea[3]
//                                     , true, true) { ColumnWidth = columnWidth, ImageIndex = newImgIndex });
//                        }//mongoList
//                        dd.Rows.Add(doc._id, alphNum.Replace(doc.name, ""), alphNum.Replace(doc.postcode, ""), doc.loc.coordinates[1], doc.loc.coordinates[0], alphNum.Replace(doc.name, "") + " " + alphNum.Replace(doc.postcode, ""));
//                    }
//                }
//            }
//            catch
//            {
//            }
//        }

//        public void getDataDBdetail(string text)
//        {
//            string check = "";
//            try
//            {
//                Regex pRegex = new Regex("[A-Z]\\d{1,2}");
//                string add = text;
//                check = add;

//                DataRow[] drRows = dd.Select("sea = '" + alphNum.Replace(add, "") + "'");
//                if (drRows.Length > 0)
//                {
//                    string[] addArr = add.Split(' ');
//                    string selLat = "", selLon = "", selPCode = "", selAddress = "";
//                    selPCode = addArr[addArr.Length - 2] + " " + addArr[addArr.Length - 1];
//                    if (!pRegex.IsMatch(selPCode))
//                        selPCode = "";
//                    string[] latArr = new string[2];
//                    string[] lngArr = new string[2];
//                    string[] pcodeArr = new string[2];
//                    string objid = "";
//                    DataRow dr = drRows[0];

//                    if ((dr != null))
//                    {
//                        selLat = (dr["lat"] != null) ? dr["lat"].ToString() : "";
//                        selLon = (dr["lng"] != null) ? dr["lng"].ToString() : "";
//                        objid = (dr["id"] != null) ? dr["id"].ToString() : "";
//                        latArr = selLat.Split('.');
//                        lngArr = selLon.Split('.');
//                        pcodeArr = selPCode.Split(' ');
//                        selAddress = (dr["name"] != null) ? dr["name"].ToString() : "";
//                        if (pcodeArr.Contains("***"))
//                        {
//                            pcodeArr[0] = "***";
//                            selPCode = "***";
//                        }
//                    }

//                    Main.MainInstance.objplac.textBox1.Text = selAddress;
//                    if (latArr[1].Length <= 5)
//                        Main.MainInstance.objplac.textBox2.Text = latArr[0] + '.' + latArr[1];
//                    else
//                        Main.MainInstance.objplac.textBox2.Text = latArr[0] + '.' + latArr[1].Substring(0, 5);
//                    if (lngArr[1].Length <= 5)
//                        Main.MainInstance.objplac.textBox3.Text = lngArr[0] + '.' + lngArr[1];
//                    else
//                        Main.MainInstance.objplac.textBox3.Text = lngArr[0] + '.' + lngArr[1].Substring(0, 5);

//                    Main.MainInstance.objplac.textBox4.Text = selPCode;
//                    Main.MainInstance.objplac.textBox5.Text = objid;
//                }
//            }
//            catch (Exception ex)
//            {
//                ExceptionalHandler.ExceptionWriter(null, ex);
//            }
//        }

//        public async void getData()
//        {
//            string check = "";
//            try
//            {
//                Regex pRegex = new Regex("[A-Z]\\d{1,2}");
//                string add = Main.MainInstance.tabMain.TabPages["Booking"].Controls["txtFromTo" + Main.MainInstance.textboxnumber].Text;
//                check = add;

//                DataRow[] drRows = dt.Select("sea = '" + alphNum.Replace(add, "") + "'");

//                if (drRows.Length > 0)
//                {
//                    string[] addArr = add.Split(' ');
//                    string selLat = "", selLon = "", selPCode = "", selAddress = "";
//                    selPCode = addArr[addArr.Length - 2] + " " + addArr[addArr.Length - 1];
//                    if (!pRegex.IsMatch(selPCode))
//                        selPCode = "";
//                    string[] latArr = new string[2];
//                    string[] lngArr = new string[2];
//                    string[] pcodeArr = new string[2];
//                    DataRow dr = drRows[0];

//                    if ((dr != null))
//                    {
//                        selLat = (dr["lat"] != null) ? dr["lat"].ToString() : "";
//                        selLon = (dr["lng"] != null) ? dr["lng"].ToString() : "";
//                        latArr = selLat.Split('.');
//                        lngArr = selLon.Split('.');
//                        pcodeArr = selPCode.Split(' ');
//                        selAddress = (dr["name"] != null) ? dr["name"].ToString() : "";
//                        if (pcodeArr.Contains("***"))
//                        {
//                            pcodeArr[0] = "***";
//                            selPCode = "***";
//                        }
//                    }

//                    Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address = selAddress;
//                    if (latArr[1].Length <= 5)
//                        Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lat = Convert.ToDouble(latArr[0] + '.' + latArr[1]);
//                    else
//                        Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lat = Convert.ToDouble(latArr[0] + '.' + latArr[1].Substring(0, 5));
//                    if (lngArr[1].Length <= 5)
//                        Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lon = Convert.ToDouble(lngArr[0] + '.' + lngArr[1]);
//                    else
//                        Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lon = Convert.ToDouble(lngArr[0] + '.' + lngArr[1].Substring(0, 5));

//                    Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].postcode = selPCode;

//                    if (Main.MainInstance.textboxnumber == 0)
//                    {
//                        Main.MainInstance.gObjBooking.from = Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address;
//                        Main.MainInstance.gObjBooking.from_outcode = pcodeArr[0];
//                    }

//                    if (Main.MainInstance.textboxnumber == 1)
//                    {
//                        Main.MainInstance.gObjBooking.to = Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address;
//                        Main.MainInstance.gObjBooking.to_outcode = pcodeArr[0];
//                    }

//                    incrementPriority(selAddress.Replace(" ", string.Empty) + pcodeArr[0]);
//                }
//                else
//                {
//                    string orignaladd = add;
//                    string[] addsplit = add.Split(' ');
//                    string postcodeCheck = "";
//                    if (addsplit.Length >= 3)
//                    {
//                        postcodeCheck = addsplit[addsplit.Length - 2] + " " + addsplit[addsplit.Length - 1];
//                    }
//                    if (!pRegex.IsMatch(postcodeCheck))
//                        postcodeCheck = "";
//                    if (addsplit.Length > 2)
//                    {
//                        addsplit = addsplit.Reverse().Skip(2).Reverse().ToArray();
//                        if (postcodeCheck == "")
//                        {
//                            add = check;
//                        }
//                        else
//                            add = string.Join(" ", addsplit);
//                    }
//                    DataRow[] drRows1 = dt1.Select("name = '" + alphNum.Replace(add, "") + "'");
//                    if (drRows1.Length > 1)
//                    {
//                        drRows1 = drRows1.CopyToDataTable().Select("postcode = '" + postcodeCheck + "'");
//                    }
//                    if (drRows1.Length > 0)
//                    {
//                        string[] addArr = orignaladd.Split(' ');
//                        string selLat = "", selLon = "", selPCode = "", selAddress = "";
//                        selPCode = addArr[addArr.Length - 2] + " " + addArr[addArr.Length - 1];
//                        if (!pRegex.IsMatch(selPCode))
//                            selPCode = "";
//                        string[] latArr = new string[2];
//                        string[] lngArr = new string[2];
//                        string[] pcodeArr = new string[2];
//                        DataRow dr = drRows1[0];

//                        if ((dr != null))
//                        {
//                            selLat = (dr["lat"] != null) ? dr["lat"].ToString() : "";
//                            selLon = (dr["lng"] != null) ? dr["lng"].ToString() : "";
//                            latArr = selLat.Split('.');
//                            lngArr = selLon.Split('.');
//                            pcodeArr = selPCode.Split(' ');
//                            selAddress = (dr["name"] != null) ? dr["name"].ToString() : "";
//                            if (pcodeArr.Contains("***"))
//                            {
//                                pcodeArr[0] = "***";
//                                selPCode = "***";
//                            }
//                        }

//                        Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address = selAddress;
//                        if (latArr[1].Length <= 5)
//                            Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lat = Convert.ToDouble(latArr[0] + '.' + latArr[1]);
//                        else
//                            Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lat = Convert.ToDouble(latArr[0] + '.' + latArr[1].Substring(0, 5));
//                        if (lngArr[1].Length <= 5)
//                            Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lon = Convert.ToDouble(lngArr[0] + '.' + lngArr[1]);
//                        else
//                            Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lon = Convert.ToDouble(lngArr[0] + '.' + lngArr[1].Substring(0, 5));

//                        Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].postcode = selPCode;

//                        if (Main.MainInstance.textboxnumber == 0)
//                        {
//                            Main.MainInstance.gObjBooking.from = Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address;
//                            Main.MainInstance.gObjBooking.from_outcode = pcodeArr[0];
//                        }

//                        if (Main.MainInstance.textboxnumber == 1)
//                        {
//                            Main.MainInstance.gObjBooking.to = Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address;
//                            Main.MainInstance.gObjBooking.to_outcode = pcodeArr[0];
//                        }

//                        incrementPriority(selAddress.Replace(" ", string.Empty) + pcodeArr[0]);
//                    }
//                }

//                if ((((Main.MainInstance.gObjBooking.fromtovia[0].lat != 0.0) && Main.MainInstance.gObjBooking.fromtovia[0].lon != 0.0))
//                      && (((Main.MainInstance.gObjBooking.fromtovia[1].lat != 0.0) && Main.MainInstance.gObjBooking.fromtovia[1].lon != 0.0)))
//                {
//                    if (Main.MainInstance.txtFromTo0.Text.Length > 0 && Main.MainInstance.txtFromTo1.Text.Length > 0 && Main.MainInstance.gObjBooking.numofvia == 0)
//                    {
//                        Program.travelType = Main.MainInstance.obj_GetAndFillQueries.GetFixedRateData("FixedPrice",
//                    Main.MainInstance.cmbAccountRef.Text,
//                    Main.MainInstance.cmbVehicleTypes.Text, Main.MainInstance.txtFromTo0.Text, Main.MainInstance.txtFromTo1.Text);
//                    }
//                    else
//                    {
//                        Main.MainInstance.lblFixed.Visible = false;

//                        Program.travelType = null;
//                    }
//                    Main.MainInstance.urldatajson();
//                }
//            }
//            catch (Exception ex)
//            {
//                ExceptionalHandler.ExceptionWriter(null, ex);
//            }
//        }

//        public void getData_dblClk()
//        {
//            try
//            {
//                if (DblClk_Addr_List.Selected_Addr != null)
//                {
//                    string[] pcodeArr = new string[2];
//                    string temp_postalcode = DblClk_Addr_List.Selected_Addr[0].postal_code;

//                    pcodeArr = temp_postalcode.Split(' ');

//                    Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address = DblClk_Addr_List.Selected_Addr[0].name;
//                    Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lat = Convert.ToDouble(DblClk_Addr_List.Selected_Addr[0].lat.ToString().Substring(0, 8));
//                    Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lon = Convert.ToDouble(DblClk_Addr_List.Selected_Addr[0].lng.ToString().Substring(0, 8));

//                    Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].postcode = DblClk_Addr_List.Selected_Addr[0].postal_code;

//                    if (Main.MainInstance.textboxnumber == 0)
//                    {
//                        Main.MainInstance.gObjBooking.from = Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address;
//                        Main.MainInstance.gObjBooking.from_outcode = pcodeArr[0];
//                    }

//                    if (Main.MainInstance.textboxnumber == 1)
//                    {
//                        Main.MainInstance.gObjBooking.to = Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address;
//                        Main.MainInstance.gObjBooking.to_outcode = pcodeArr[0];
//                    }
//                }
//                else
//                {
//                    string[] pcodeArr = new string[2];
//                    string temp_postalcode = DblClk_Addr_List.Selected_Addr[0].postal_code;

//                    pcodeArr = temp_postalcode.Split(' ');

//                    Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address = DblClk_Addr_List.Selected_Addr[0].name;
//                    Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lat = Convert.ToDouble(DblClk_Addr_List.Selected_Addr[0].lat.ToString().Substring(0, 5));
//                    Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].lon = Convert.ToDouble(DblClk_Addr_List.Selected_Addr[0].lng.ToString().Substring(0, 5));

//                    Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].postcode = DblClk_Addr_List.Selected_Addr[0].postal_code;

//                    if (Main.MainInstance.textboxnumber == 0)
//                    {
//                        Main.MainInstance.gObjBooking.from = Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address;

//                        Main.MainInstance.gObjBooking.from_outcode = pcodeArr[0];
//                    }

//                    if (Main.MainInstance.textboxnumber == 1)
//                    {
//                        Main.MainInstance.gObjBooking.to = Main.MainInstance.gObjBooking.fromtovia[Main.MainInstance.textboxnumber].address;

//                        Main.MainInstance.gObjBooking.to_outcode = pcodeArr[0];
//                    }
//                }

//                if ((((Main.MainInstance.gObjBooking.fromtovia[0].lat != 0.0) && Main.MainInstance.gObjBooking.fromtovia[0].lon != 0.0))
//                      && (((Main.MainInstance.gObjBooking.fromtovia[1].lat != 0.0) && Main.MainInstance.gObjBooking.fromtovia[1].lon != 0.0)))
//                {
//                    if (Main.MainInstance.txtFromTo0.Text.Length > 0 && Main.MainInstance.txtFromTo1.Text.Length > 0 && Main.MainInstance.gObjBooking.numofvia == 0)
//                    {
//                        Program.travelType = Main.MainInstance.obj_GetAndFillQueries.GetFixedRateData("FixedPrice",
//                    Main.MainInstance.cmbAccountRef.Text,
//                    Main.MainInstance.cmbVehicleTypes.Text, Main.MainInstance.txtFromTo0.Text, Main.MainInstance.txtFromTo1.Text);
//                    }
//                    else
//                    {
//                        Main.MainInstance.lblFixed.Visible = false;

//                        Program.travelType = null;
//                    }
//                    Main.MainInstance.urldatajson();
//                }
//            }
//            catch (Exception ex)
//            {
//                ExceptionalHandler.ExceptionWriter(null, ex);
//            }
//        }

//        public void incrementPriority(string address)
//        {
//            try
//            {
//                var json_collectionP = database.GetCollection<ukgeoJsonResults>("ukgeojson");
//                var addressQuery = Query.EQ("sea", address.Replace(" ", string.Empty));
//                var query = Query.And(addressQuery, Query.EQ("officePriority.officename", Program.officeAbb));
//                var updateValues = new List<UpdateBuilder>();
//                updateValues.Add(Update.Inc("officePriority." + Program.officeAbb, 1));
//                IMongoUpdate updateMult = Update.Combine(updateValues);
//                json_collectionP.Update(addressQuery, updateMult, UpdateFlags.Upsert);
//            }
//            catch (Exception ex)
//            {
//                ExceptionalHandler.ExceptionWriter(null, ex);
//            }
//        }

//        public static void updateInvoice(IMongoQuery query)
//        {
//            try
//            {
//                var BCOldcollectionP = database.GetCollection<ukgeoJsonResults>("BookingClosed");

//                var updateValues = new List<UpdateBuilder>();
//                updateValues.Add(Update.BitwiseOr("mstate", 001));
//                IMongoUpdate updateMult = Update.Combine(updateValues);
//                BCOldcollectionP.Update(query, updateMult, UpdateFlags.Multi);
//            }
//            catch (Exception ex)
//            {
//                ExceptionalHandler.ExceptionWriter(null, ex);
//            }
//        }

//        public static void updateStatement(IMongoQuery query)
//        {
//            try
//            {
//                var BCOldcollectionP = database.GetCollection<ukgeoJsonResults>("BookingClosed");

//                var updateValues = new List<UpdateBuilder>();
//                updateValues.Add(Update.BitwiseOr("mstate", 010));
//                IMongoUpdate updateMult = Update.Combine(updateValues);
//                BCOldcollectionP.Update(query, updateMult, UpdateFlags.Multi);
//            }
//            catch (Exception ex)
//            {
//                ExceptionalHandler.ExceptionWriter(null, ex);
//            }
//        }
//    }

//    public class Locpointinpolygon
//    {
//        private double lt;
//        private double lg;

//        public double Lg
//        {
//            get { return lg; }
//            set { lg = value; }
//        }

//        public double Lt
//        {
//            get { return lt; }
//            set { lt = value; }
//        }

//        public Locpointinpolygon(double lt, double lg)
//        {
//            this.lt = lt;
//            this.lg = lg;
//        }
//    }

//    public class Loc
//    {
//        public string type { get; set; }
//        public List<double> coordinates { get; set; }
//    }

//    public class ukgeoJsonResults
//    {
//        public ObjectId _id { get; set; }
//        public string name { get; set; }
//        public string postcode { get; set; }
//        public Loc loc { get; set; }
//        public int cat { get; set; }
//        public List<string> sea { get; set; }
//    }

//    public class ukgeoJsonResults1
//    {
//        public double id { get; set; }

//        public string name { get; set; }
//        public string postcode { get; set; }
//        public double lat { get; set; }
//        public double lng { get; set; }
//    }

//    public class CacheDataUpdate
//    {
//        public double id { get; set; }
//        public double datentime { get; set; }

//        public string name { get; set; }
//        public string postcode { get; set; }
//        public double lat { get; set; }
//        public double lng { get; set; }
//    }

//    public struct LatLonNearest
//    {
//        public double Latitude;
//        public double Longtitude;

//        public LatLonNearest(double latitude, double longtitude)
//        {
//            Latitude = latitude;
//            Longtitude = longtitude;
//        }
//    }

//    public struct ListElement
//    {
//        public string callsign;
//        public string office;
//        public double distance;
//        public string Vtype;
//    }

//    public class CacheBooking
//    {
//        public string from { get; set; }
//        public string to { get; set; }
//        public string office { get; set; }
//        public string vehicletype { get; set; }
//        public string account { get; set; }

//        public double fare { get; set; }
//        public double mileage { get; set; }
//    }

//    public class AvoidAreasCache
//    {
//        public string office { get; set; }
//        public double lattitude { get; set; }
//        public double longitude { get; set; }
//        public double width { get; set; }
//        public double height { get; set; }

//        public double name { get; set; }
//    }

//    public class PlotsCache
//    {
//        public string office { get; set; }
//        public string points { get; set; }
//        public string plotname { get; set; }
//        public string outcode { get; set; }
//        public bool local { get; set; }
//    }
//}
//}
