using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0601_DecoratorPattern
{
    internal abstract class AbstractDecorator : AbstractComponent
    {
        private AbstractComponent absComponent;

        public void SetComponent(AbstractComponent absCom)
        {
            this.absComponent = absCom;
        }

        public override void Operation()
        {
            absComponent.Operation();
        }
    }
}