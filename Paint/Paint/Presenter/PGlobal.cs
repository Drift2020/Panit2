using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Presenter
{
    class PGlobal
    {
        private readonly Interface.IGlobal _viwe;
       

        public PGlobal(Interface.IGlobal viwe)
        {
            _viwe = viwe;
            _viwe.RadioButton += new EventHandler<EventArgs>(RadioButton);

        }

        private void RadioButton(object sender, EventArgs e)
        {
           if(_viwe.NameRadioButton=="")
           {

           }
           else if (_viwe.NameRadioButton == "")
            {

            }
           else if (_viwe.NameRadioButton == "")
            {

            }
           else if (_viwe.NameRadioButton == "")
            {

            }
        }
    }
}
