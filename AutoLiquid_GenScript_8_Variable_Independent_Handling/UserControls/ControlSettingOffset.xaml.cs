using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AutoLiquid_GenScript_8_Variable_Independent_Handling.Utils;
using DataHelper = AutoLiquid_GenScript_8_Variable_Independent_Handling.Utils.DataHelper;

namespace AutoLiquid_GenScript_8_Variable_Independent_Handling.UserControls
{
    /// <summary>
    /// 偏移设置控件
    /// </summary>
    public partial class ControlSettingOffset : UserControl
    {
        // 移液头Index
        private int mHeadIndex;

        public ControlSettingOffset(int headIndex)
        {
            InitializeComponent();

            this.mHeadIndex = headIndex;

            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            // 初始化控件
            InitWidget();
            // 控件事件
            ControlEvent();
        }

        private void InitWidget()
        {
            this.TextBoxOffsetZ2.Text = ParamsHelper.Offsets.ZOffset[0].ToString();
            this.TextBoxOffsetZ3.Text = ParamsHelper.Offsets.ZOffset[1].ToString();
            this.TextBoxOffsetZ4.Text = ParamsHelper.Offsets.ZOffset[2].ToString();
            this.TextBoxOffsetZ5.Text = ParamsHelper.Offsets.ZOffset[3].ToString();
            this.TextBoxOffsetZ6.Text = ParamsHelper.Offsets.ZOffset[4].ToString();
            this.TextBoxOffsetZ7.Text = ParamsHelper.Offsets.ZOffset[5].ToString();
            this.TextBoxOffsetZ8.Text = ParamsHelper.Offsets.ZOffset[6].ToString();
        }

        private void ControlEvent()
        {
            this.TextBoxOffsetZ2.TextChanged += TextBoxOnTextChanged;
            this.TextBoxOffsetZ3.TextChanged += TextBoxOnTextChanged;
            this.TextBoxOffsetZ4.TextChanged += TextBoxOnTextChanged;
            this.TextBoxOffsetZ5.TextChanged += TextBoxOnTextChanged;
            this.TextBoxOffsetZ6.TextChanged += TextBoxOnTextChanged;
            this.TextBoxOffsetZ7.TextChanged += TextBoxOnTextChanged;
            this.TextBoxOffsetZ8.TextChanged += TextBoxOnTextChanged;
        }

        private void TextBoxOnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender.Equals(this.TextBoxOffsetZ2))
                DataHelper.SaveDecimal(this.mHeadIndex, this.TextBoxOffsetZ2.Text.Trim(), ref ParamsHelper.Offsets.ZOffset[0], () => FileUtils.SaveOffsets(ParamsHelper.Offsets));
            else if (sender.Equals(this.TextBoxOffsetZ3))
                DataHelper.SaveDecimal(this.mHeadIndex, this.TextBoxOffsetZ3.Text.Trim(), ref ParamsHelper.Offsets.ZOffset[1], () => FileUtils.SaveOffsets(ParamsHelper.Offsets));
            else if (sender.Equals(this.TextBoxOffsetZ4))
                DataHelper.SaveDecimal(this.mHeadIndex, this.TextBoxOffsetZ4.Text.Trim(), ref ParamsHelper.Offsets.ZOffset[2], () => FileUtils.SaveOffsets(ParamsHelper.Offsets));
            else if (sender.Equals(this.TextBoxOffsetZ5))
                DataHelper.SaveDecimal(this.mHeadIndex, this.TextBoxOffsetZ5.Text.Trim(), ref ParamsHelper.Offsets.ZOffset[3], () => FileUtils.SaveOffsets(ParamsHelper.Offsets));
            else if (sender.Equals(this.TextBoxOffsetZ6))
                DataHelper.SaveDecimal(this.mHeadIndex, this.TextBoxOffsetZ6.Text.Trim(), ref ParamsHelper.Offsets.ZOffset[4], () => FileUtils.SaveOffsets(ParamsHelper.Offsets));
            else if (sender.Equals(this.TextBoxOffsetZ7))
                DataHelper.SaveDecimal(this.mHeadIndex, this.TextBoxOffsetZ7.Text.Trim(), ref ParamsHelper.Offsets.ZOffset[5], () => FileUtils.SaveOffsets(ParamsHelper.Offsets));
            else if (sender.Equals(this.TextBoxOffsetZ8))
                DataHelper.SaveDecimal(this.mHeadIndex, this.TextBoxOffsetZ8.Text.Trim(), ref ParamsHelper.Offsets.ZOffset[6], () => FileUtils.SaveOffsets(ParamsHelper.Offsets));
        }

        private void BtnOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
                MessageBox.Show(ex.Message, "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
