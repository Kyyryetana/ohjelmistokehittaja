using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUD20
{
    class Yhdista
    {
        /*public string yhteyslause()
        {
            return "Datasource=localhost; port=3306; username=root; password=; database=hotelli";
        }*/

        private MySqlConnection yhteys = new MySqlConnection("Datasource=localhost; port=3306; username=root; password=; database=opiskelijat");
        
        // luodaan funktio yhteyttä varten
        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        // luodaan funktio yhteyden avaamista varten
        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        //luodaan funktio yhteyden sulkemista varten
        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
