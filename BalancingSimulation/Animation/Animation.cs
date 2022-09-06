using System;

namespace BalancingSimulation.Animation
{
    public class Animation
    {
        public string Id { get; set; }

        public float Value;

        public float StartValue;

        private float _targetValue;
        public float TargetValue
        {
            get => _targetValue;
            set
            {
                _targetValue = value;
                Reverse = value < Value;
            }
        }

        public float Volume;

        public bool Reverse;

        public AnimationStatus Status { get; set; }
        public enum AnimationStatus
        {
            Requested,
            Active,
            Completed
        }

        private readonly float _p15;
        private readonly float _p30;
        private readonly float _p70;
        private readonly float _p85;

        public int StepDivider = 11;

        private float Step()
        {
            float basicStep = Math.Abs(Volume) / StepDivider; // Math.Abs - превращает числа 0< в >0
            float resultStep = 0;

            if(Reverse == false)
            {
                if(Value <= _p15 || Value >= _p85)
                {
                    resultStep = basicStep / 3.5f;
                }
                else if (Value <= _p30 || Value >= _p70)
                {
                    resultStep = basicStep / 2f;
                }
                else if(Value > _p30 && Value < _p70)
                {
                    resultStep = basicStep;
                }
            }
            else
            {
                if (Value >= _p15 || Value <= _p85)
                {
                    resultStep = basicStep / 3.5f;
                }
                else if (Value >= _p30 || Value <= _p70)
                {
                    resultStep = basicStep / 2f;
                }
                else if (Value < _p30 && Value > _p70)
                {
                    resultStep = basicStep;
                }
            }

            return Math.Abs(resultStep);
        }

        private float ValueByPercent(float percent)
        {
            float volumeInPercent = Volume * percent / 100;
            float valueInPercent = StartValue + volumeInPercent;

            return valueInPercent;
        }

        public delegate void ControlMethod();
        private readonly ControlMethod _invalidateControl;

        public void UpdateFrame()
        {
            Status = AnimationStatus.Active;

            if (Reverse == false)
            {
                if(Value <= _targetValue)
                {
                    Value += Step();

                    if(Value >= _targetValue)
                    {
                        Value = _targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }
            else
            {
                if (Value >= _targetValue)
                {
                    Value -= Step();

                    if (Value <= _targetValue)
                    {
                        Value = _targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }

            _invalidateControl.Invoke();
        }

        public Animation() { }

        public Animation(string id, ControlMethod invalidateControl, float value, float targetValue)
        {
            this.Id = id;

            this._invalidateControl = invalidateControl;

            this.Value = value;
            this.TargetValue = targetValue;

            StartValue = value;
            Volume = targetValue - value;

            _p15 = ValueByPercent(15);
            _p30 = ValueByPercent(30);
            _p70 = ValueByPercent(70);
            _p85 = ValueByPercent(85);
        }
    }
}
