using System;

namespace Server.Items
{
    public class WheelbarrowPottedPlantRed : Item, IDyable
    {
        [Constructable]
        public WheelbarrowPottedPlantRed()
            : this(1)
        {
        }

        [Constructable]
        public WheelbarrowPottedPlantRed(int amount)
            : base(0xA0EB)
        {
            this.Stackable = false;
            this.Amount = amount;
        }

        public WheelbarrowPottedPlantRed(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1125220;
            }
        }// potted plant
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
        #region IDyable
        public virtual bool Dye(Mobile from, DyeTub sender)
        {
            if (this.Deleted)
                return false;

            this.Hue = sender.DyedHue;
            return true;
        }
        #endregion
    }
}
