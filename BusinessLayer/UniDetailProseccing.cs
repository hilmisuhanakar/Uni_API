using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Nancy.Json;
using System.Linq;

namespace BusinessLayer
{
    public class UniDetailProseccing : UniAtlasDbContext
    {
        UniAtlasDbContext db;
        List<UniDetail> list;
        public UniDetailProseccing()
        {
            db = new UniAtlasDbContext();
            list = db.UniDetails.ToList();
        }

        public List<UniDetail> AllList()
        {
            return (list);
        }


        public List<UniSummary> Detail()
        {
            List<UniSummary> listDetail = new List<UniSummary>();

            foreach (var item in list)
            {
                listDetail.Add(new UniSummary(item.Id, item.UniName, item.City, item.Img, item.Slug));
            }
            return (listDetail);
        }

        public List<UniSummary> DetailName(string UniName)
        {
            List<UniSummary> listNameDetail = new List<UniSummary>();
            foreach (var item in list)
            {
                if (item.UniName.ToLower().Contains(UniName))
                {
                    listNameDetail.Add(new UniSummary(item.Id, item.UniName, item.City, item.Img, item.Slug));
                }
            }
            return (listNameDetail);
        }


        //public List<UniDetail> FromUniName(string UniName)
        //{
        //    List<UniDetail> ListUniName = new List<UniDetail>();
        //    foreach (var item in list)
        //    {
        //        if (item.UniName.ToLower().Contains(UniName))
        //        {
        //            ListUniName.Add(item);
        //        }
        //    }
        //    return (ListUniName);
        //}

        public List<UniDetail> FromId(int Id)
        {
            List<UniDetail> ListId = new List<UniDetail>();

            foreach (var item in list)
            {
                if (item.Id==Id)
                {
                    ListId.Add(item);
                }
            }

            return (ListId);
        }
    }
}
