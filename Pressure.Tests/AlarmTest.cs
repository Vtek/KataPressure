using Xunit;

namespace Pressure.Test
{
    public class AlarmTest
    {
        [Fact]
        public void Foo()
        {
            Alarm alarm = new Alarm();
            Assert.Equal(false, alarm.AlarmOn);
        }
    }
}