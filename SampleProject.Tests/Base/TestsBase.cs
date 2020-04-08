namespace SampleProject.Tests.Base
{
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class TestsBase
    {
        protected MockRepository MockRepository { get; private set; }

        public TestsBase()
        {
            this.MockRepository = new MockRepository(MockBehavior.Default);
        }
    }
}
