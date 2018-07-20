using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCorate
{
    public abstract class Component
    {
        public abstract string Show();
    }

    public abstract  class DecorateComponent : Component
    {
        private Component _component;
        public DecorateComponent(Component component)
        {
            _component = component;
        }

        public override string Show()
        {
           return   _component.Show();
        }
    }


    public sealed class SafeDecote:DecorateComponent
    {
        public SafeDecote(Component component):base(component)
        {

        }
        public override string Show()
        {
            return base.Show()+"添加安全机制";
        }
    }

    public sealed class TransformDecore:DecorateComponent
    {
        public TransformDecore(Component component):base(component)
        {

        }
        public override string Show()
        {
            return base.Show()+"添加平移功能";
        }
    }

    public sealed class  CabinDecorate:DecorateComponent
    {
        public CabinDecorate(Component component):base(component)
        {

        }

        public override string Show()
        {
            return base.Show()+"厨房修饰";
        }
    }

    public class MYHouse : Component
    {
        public override string Show()
        {
            return "myhouse";
        }
    }

}