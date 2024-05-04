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
        List<GameObject> gameObjectList;
        Form container;
        List<CollisionDetection> collisions;

        public Game(Form container)
        {
            this.gameObjectList = new List<GameObject>();
            this.container = container;
            collisions = new List<CollisionDetection>();
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
            CheckCollisions();
        }

        public void CheckCollisions()
        {
            foreach (GameObject GO in gameObjectList)
            {
                if (GO.getObjectType() == ObjectType.player)
                {

                    foreach (GameObject GO1 in gameObjectList)
                    {
                        if (GO1.getObjectType() == ObjectType.enemy)
                        {

                            if (CollisionDetection.IsCollided(GO, GO1))
                            {
                                CollisionDetection cd = new CollisionDetection(GO, GO1);
                                collisions.Add(cd);
                                GO.health-=10;
                            }
                        }
                    }
                }
            }
        }

        public List<CollisionDetection> getlist()
        {
            return this.collisions;
        }
    }
}
