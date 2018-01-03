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
        private readonly string[] instrument; 

        public PGlobal(Interface.IGlobal viwe)
        {
           
            _viwe = viwe;
            instrument = _viwe.Instrument;
            _viwe.RadioButton += new EventHandler<EventArgs>(RadioButton);

        }

        private void RadioButton(object sender, EventArgs e)
        {
           if(_viwe.NameRadioButton== instrument[0])
           {

           }
           else if (_viwe.NameRadioButton == instrument[1])
            {

            }
           else if (_viwe.NameRadioButton == instrument[2])
            {

            }
           else if (_viwe.NameRadioButton == instrument[3])
            {

            }
        }
    }
}
