
using Microsoft.AspNetCore.Mvc;
using System.Linq.Dynamic.Core;
using X.PagedList;
using X.PagedList.Extensions;
//using SkakERP.Entities.Identity.ViewModel;

namespace MetroVMS.Models.PageModels
{
    public class PagedListBasePageModel : BasePageModel
    {
        [BindProperty]
        public int? pageNo { get; set; }
        [BindProperty]
        public int? pageSize { get; set; }
        public bool hasPagination { get; set; }
        public string sortDirection { get; set; }
        public string sortText { get; set; }
        [BindProperty]
        public string sortColumn { get; set; }
        [BindProperty]
        public string sortOrder { get; set; }

        [BindProperty]
        public string searchField { get; set; }
        [BindProperty]
        public string globalSearch { get; set; }

        [BindProperty]
        public string globalSearchColumn { get; set; }

        public List<PageListFilterColumns> pageListFilterColumns { get; set; }

        public IPagedList<T> PagedList<T>(List<T> sourceData)
        {
            var pn = pageNo ?? 1;
            var ps = pageSize ?? 10;

            try
            {
                if (!string.IsNullOrEmpty(sortColumn))
                {
                    var param = sortColumn;
                    var propertyInfo = typeof(T).GetProperty(param);

                    if (sortOrder == "0")
                    {
                        var orderBy = sourceData.OrderByDescending(x => propertyInfo?.GetValue(x, null));
                        sourceData = orderBy.ToList();
                    }
                    else
                    {
                        var orderBy = sourceData.OrderBy(x => propertyInfo?.GetValue(x, null));
                        sourceData = orderBy.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                if (!string.IsNullOrEmpty(globalSearch))
                {
                    globalSearch = globalSearch?.ToLower();

                    if (!string.IsNullOrEmpty(searchField) && searchField != "All")
                    {
                        var param = searchField;
                        var propertyInfo = typeof(T).GetProperty(param);
                        if (propertyInfo != null)
                        {
                            var filterData = sourceData.Where(x => (propertyInfo.GetValue(x, null) ?? "").ToString().ToLower().Contains(globalSearch))?.ToList();
                            if (filterData != null)
                            {
                                sourceData = filterData.ToList();
                            }
                        }
                    }
                    else
                    {
                        if (pageListFilterColumns.Count > 0)
                        {
                            string sqlFilter = "";
                            var dSource = sourceData.AsQueryable();
                            foreach (var column in pageListFilterColumns)
                            {
                                var propertyInfo = typeof(T).GetProperty(column.ColumName);
                                if (propertyInfo != null)
                                {
                                    if (!string.IsNullOrEmpty(sqlFilter))
                                    {
                                        sqlFilter = $"{sqlFilter} or ";
                                    }
                                    sqlFilter = $"{sqlFilter} ({column.ColumName.Trim()} == null ? \"\":  {column.ColumName.Trim()}).ToLower().Contains(@0)";
                                }
                            }

                            if (!string.IsNullOrEmpty(sqlFilter))
                            {
                                var filterData = dSource.Where(sqlFilter, globalSearch).ToList();
                                sourceData = filterData.ToList();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            var pagedListData = sourceData.ToPagedList(pn, ps);
            hasPagination = sourceData.Count() > ps ? true : false;

            pageNo = pn;
            pageSize = ps;
            return pagedListData;
        }


    }
}
