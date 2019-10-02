﻿using System.Collections.Generic;

namespace Ninja_Price.API.PoeNinja.Classes
{
    public class Resonators
    {
        public class Sparkline
        {
            public List<object> Data { get; set; }
            public double TotalChange { get; set; }
        }

        public class LowConfidenceSparkline
        {
            public List<object> Data { get; set; }
            public double TotalChange { get; set; }
        }

        public class ExplicitModifier
        {
            public string Text { get; set; }
            public bool Optional { get; set; }
        }

        public class Line
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public int MapTier { get; set; }
            public int LevelRequired { get; set; }
            public object BaseType { get; set; }
            public int StackSize { get; set; }
            public object Variant { get; set; }
            public object ProphecyText { get; set; }
            public object ArtFilename { get; set; }
            public int Links { get; set; }
            public int ItemClass { get; set; }
            public Sparkline Sparkline { get; set; }
            public LowConfidenceSparkline LowConfidenceSparkline { get; set; }
            public List<object> ImplicitModifiers { get; set; }
            public List<ExplicitModifier> ExplicitModifiers { get; set; }
            public string FlavourText { get; set; }
            public bool Corrupted { get; set; }
            public int GemLevel { get; set; }
            public int GemQuality { get; set; }
            public string ItemType { get; set; }
            public double ChaosValue { get; set; }
            public double ExaltedValue { get; set; }
            public int Count { get; set; }
            public string DetailsId { get; set; }
        }

        public class RootObject
        {
            public List<Line> Lines { get; set; }
        }
    }
}