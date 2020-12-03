using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace generalizedService
{
    [RunInstaller(true)]
    public partial class GeneralizedServiceInstaller : System.Configuration.Install.Installer
    {
        public GeneralizedServiceInstaller()
        {
            InitializeComponent();
        }
    }
}
