using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BalancingSimulation.Animation
{
    public static class Animator
    {
        public static List<global::BalancingSimulation.Animation.Animation> AnimationList = new List<Animation>();

        public static int Count()
        {
            return AnimationList.Count;
        }

        private static Thread _animatorThread;

        private static double _interval;

        public static bool IsWork;
        
        public static void Start()
        {
            IsWork = true;
            _interval = 14; // FPS ~66

            _animatorThread = new Thread(AnimationInvoker)
            {
                IsBackground = true,
                Name = "UI Animation"
            };

            _animatorThread.Start();
        }

        private static void AnimationInvoker()
        {
            while (IsWork)
            {
                AnimationList.RemoveAll(a => a == null || a.Status == global::BalancingSimulation.Animation.Animation.AnimationStatus.Completed);

                Parallel.For(0, Count(), index =>
                {
                    AnimationList[index].UpdateFrame();
                });

                Thread.Sleep((int)_interval);
            }
        }

        public static void Request(global::BalancingSimulation.Animation.Animation anim, bool replaceIfExists = true)
        {
            Debug.WriteLine("Запуск анимации: " + anim.Id + "| TargetValue: " + anim.TargetValue);
            anim.Status = global::BalancingSimulation.Animation.Animation.AnimationStatus.Requested;

            global::BalancingSimulation.Animation.Animation dupAnim = GetDuplicate(anim);

            if(dupAnim != null)
            {
                if(replaceIfExists == true)
                {
                    dupAnim.Status = global::BalancingSimulation.Animation.Animation.AnimationStatus.Completed;
                }
                else
                {
                    return;
                }
            }

            AnimationList.Add(anim);
        }

        private static global::BalancingSimulation.Animation.Animation GetDuplicate(global::BalancingSimulation.Animation.Animation anim)
        {
            return AnimationList.Find(a => a.Id == anim.Id);
        }
    }
}
