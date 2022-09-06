using System;
using System.Windows.Forms;

namespace BalancingSimulation.Controls
{
    class MyRadioButton : RadioButton
    {
        #region -- Переменные --

        private bool _isChecked;

        #endregion

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (_isChecked)
            {
                if (Checked)
                {
                    Checked = false;
                }
            }
            _isChecked = !_isChecked;
        }
    }
}
