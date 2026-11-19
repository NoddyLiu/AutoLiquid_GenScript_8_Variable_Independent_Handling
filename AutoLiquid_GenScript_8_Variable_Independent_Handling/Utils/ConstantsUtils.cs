using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLiquid_Library.Enum;

namespace AutoLiquid_GenScript_8_Variable_Independent_Handling.Utils
{
    public class ConstantsUtils
    {
        // 量程最大值
        public static Dictionary<ELiquidRange, decimal> LiquidRangeMaxDic = new Dictionary<ELiquidRange, decimal>
        {
            {ELiquidRange.Ten, ParamsHelper.Range.Ten},
            {ELiquidRange.Twenty, ParamsHelper.Range.Twenty },
            {ELiquidRange.TwoHundred, ParamsHelper.Range.TwoHundred},
            {ELiquidRange.OneThousand, ParamsHelper.Range.OneThousand},
            {ELiquidRange.FiveThousand, ParamsHelper.Range.FiveThousand},
        };

        // 主界面每个盘位占据Grid的多少比重
        public static int TemplateOccupyGridSpan = 2;

        // 枪头盒固定盘位Index
        public static List<int> TipTemplateIndexList = new List<int> { 0, 5, 10, 15 };

        // 退枪头固定盘位Index
        public static int ReleaseTipTemplateIndex = 20;

        // EP管架固定盘位Index（EP管架的摆放位置，最左上角盘位Index）
        public static List<int> EPTemplateIndexList = new List<int> { 1, 3, 6, 8 };

        /// <summary>
        /// EP管架所占用的全部盘位Index（EP管架占1.5行标准耗材和2列标准耗材）
        /// </summary>
        /// <param name="index">EP管架所在盘位Index（左上角那个）</param>
        public static List<int> GetEPTemplateCoverIndexList(int index)
        {
            var result = new List<int> { index };
            var colCount = ParamsHelper.Layout.ColCount;
            var rowCount = ParamsHelper.Layout.RowCount;
            var col = index % colCount;
            var row = index / colCount;

            if (col + 1 < colCount) result.Add(index + 1);
            if (row + 1 < rowCount)
            {
                result.Add(index + colCount);
                if (col + 1 < colCount) result.Add(index + colCount + 1);
            }
            return result;
        }

        /// <summary>
        /// EP管架专用盘位所占用的全部盘位Index
        /// （取前N个EP专用盘位，并把它们连带覆盖的盘位一起算进去）
        /// </summary>
        /// <param name="epCount">本次使用的EP管架个数</param>
        public static List<int> GetEPTemplateReservedIndexList(int epCount)
        {
            var result = new List<int>();
            foreach (var anchor in EPTemplateIndexList.Take(Math.Min(epCount, EPTemplateIndexList.Count)))
            {
                foreach (var idx in GetEPTemplateCoverIndexList(anchor))
                {
                    if (!result.Contains(idx))
                        result.Add(idx);
                }
            }
            return result;
        }
    }
}
