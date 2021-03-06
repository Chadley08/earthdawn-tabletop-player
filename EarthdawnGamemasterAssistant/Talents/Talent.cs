﻿using System.Collections.Specialized;
using EarthdawnGamemasterAssistant.CharacterGenerator.Actions;
using EarthdawnGamemasterAssistant.CharacterGenerator.Annotations;
using EarthdawnGamemasterAssistant.CharacterGenerator.Attributes;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EarthdawnGamemasterAssistant.CharacterGenerator.Skills;

namespace EarthdawnGamemasterAssistant.CharacterGenerator.Talents
{
    public class Talent : INotifyPropertyChanged
    {
        public string Name { get; }
        public string Description { get; }
        public EarthdawnAttribute BaseEarthdawnAttribute { get; }
        private int _rank;

        public int Rank
        {
            get => _rank;
            set
            {
                _rank = value;
                OnPropertyChanged();
            }
        }

        public IStepRule StepRule { get; }
        public ActionType Action { get; }
        public int Strain { get; }

        public Talent(
            string name,
            string description,
            EarthdawnAttribute baseEarthdawnAttribute,
            int rank,
            IStepRule stepRule,
            ActionType action,
            int strain,
            bool skillUse,
            string skillDescription)
        {
            Name = name;
            Description = description;
            BaseEarthdawnAttribute = baseEarthdawnAttribute;
            Rank = rank;
            StepRule = stepRule;
            Action = action;
            Strain = strain;
            SkillUse = skillUse;
            SkillDescription = skillDescription;
        }

        public bool SkillUse { get; }
        public string SkillDescription { get; }

        public int GetStep(int attributeValue)
        {
            var attributeStep = CharacteristicTables.GetStepFromValue(attributeValue);
            return StepRule.CalculateStep(Rank, attributeStep);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}