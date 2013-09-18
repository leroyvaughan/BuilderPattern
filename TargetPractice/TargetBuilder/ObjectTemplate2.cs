using System;

namespace TargetPractice.TargetBuilder
{
    public abstract class ObjectTemplate2
    {
        public string _color;
        public string _objectType;
        public int _points;
        public int _speed;

        //these methods are abstract in ObjectTemplate1
        public virtual void SetPointsValue(int Points){ _points = Points; }
        public virtual void SetObjectColor(string Color){ _color = Color; }
        public virtual void SetObjectSpeed(int Speed){ _speed = Speed; }

        public void SetObjectProperties()
        {
            Console.WriteLine("{0} colored {1} worth {2} points falling at speed {3}.\r\n",
                                _color, _objectType, _points, _speed);
        }
    }
}