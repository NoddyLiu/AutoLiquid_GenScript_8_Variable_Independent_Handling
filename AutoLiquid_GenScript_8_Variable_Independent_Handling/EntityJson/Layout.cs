using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using AutoLiquid_Library.Enum;

namespace AutoLiquid_GenScript_8_Variable_Independent_Handling.EntityJson
{
    /// <summary>
    /// 盘位行列布局
    /// </summary>
    [Serializable()]
    public class Layout
    {
        // 行数
        public int RowCount =5;

        // 列数
        public int ColCount = 5;
    }
}
