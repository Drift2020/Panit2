using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Interface
{
    public interface IGlobal
    {
        event EventHandler<EventArgs> RadioButton;
        event EventHandler<EventArgs> OpenImage;
        event EventHandler<EventArgs> SaveImage;
        event EventHandler<EventArgs> NewImage;
        string NameRadioButton{set; get;}
        string[] Instrument { set; get; }
    }
}
