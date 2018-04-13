﻿using System;
using System.Xml.Serialization;
using VRage.ObjectBuilders;
using VRage.ObjectBuilders.Components.Entity.Stats.Definitions;
using VRage.ObjectBuilders.Definitions;

namespace RomScripts.StaminaEffect
{
    [MyObjectBuilderDefinition]
    [XmlSerializerAssembly("MedievalEngineers.ObjectBuilders.XmlSerializers")]
    public class MyObjectBuilder_RomStaminaEffectDefinition : MyObjectBuilder_EntityStatEffectDefinition
    {
        public SerializableDefinitionId ExhaustionEffect;

        public SerializableDefinitionId RestingEffect;

        public TimeDefinition? RestingTime;

        /// <summary>
        /// The ratio of food consumed for every 1 stamina regenerated.
        /// </summary>
        public float? StaminaToFoodRatio;

        /// <summary>
        /// The ratio of thirst consumed for every 1 stamina regenerated.
        /// </summary>
        public float? StaminaToThirstRatio;
    }
}