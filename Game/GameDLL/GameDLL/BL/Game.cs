using GameDLL.DLLinterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDLL.BL
{
    public class Game
    {
        List<GameObject> gameObjectList ;
        Form container;

        public Game(Form container)
        {
            this.gameObjectList = new List<GameObject>();
            this.container = container;
        }

        public void AddGameObjects(GameObject myobject)
        {
            GameObject gameObject = myobject;
            gameObjectList.Add(gameObject);
            container.Controls.Add(gameObject.getPictureBox());
        }

        public void update()
        {
            foreach (GameObject gameObject in gameObjectList)
            {
                gameObject.update();
            }
        }


    }
}
