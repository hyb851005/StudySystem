using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SystemMgr.DAL
{
   public class DalCommon
    {
        /// <summary>
        /// ���ص���˼���б��¼ 
        /// </summary>
        /// <returns>DateSet</returns>
        public static DataSet GetKejianList()
        {
            return SqlHelper.GetDs("select * from FileInfo  order by addtime desc", "kejian");
        }
    }


}
