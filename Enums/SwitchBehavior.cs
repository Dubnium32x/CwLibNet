using CwLibNet.IO;

namespace CwLibNet.Enums
{
    public enum SwitchBehavior
    {
        // OFF_ON(0)
        OFF_ON,
        // SPEED_SCALE(1)
        SPEED_SCALE,
        // DIRECTION(2)
        DIRECTION,
        // ONE_SHOT(3)
        ONE_SHOT 
    }
    public sealed class SwitchBehaviorBody
    {
        private readonly SwitchBehavior value;

        SwitchBehaviorBody(int value)
        {
            this.value = (SwitchBehavior)(value);
        }

        public SwitchBehavior getValue()
        {
            return this.value;
        }

        public static SwitchBehaviorBody fromValue(int value)
        {
            if (Enum.IsDefined(typeof(SwitchBehavior), value))
                return new SwitchBehaviorBody(value);
            return default(SwitchBehaviorBody);
        }
    }
}