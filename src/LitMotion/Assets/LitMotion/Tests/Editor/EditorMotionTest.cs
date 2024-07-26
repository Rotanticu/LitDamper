using UnityEngine;
using LitDamper.Editor;
using System.Collections;
using UnityEngine.TestTools;

namespace LitDamper.Tests.Editor
{
    public class EditorMotionTest
    {
        public float currentValue = 0f;
        [UnityTest]
        public IEnumerator Test_1()
        {
            bool completed = false;
            LDamper.CreateDamper(()=> currentValue, (value) => currentValue = value, () => 1f)
                .WithOnComplete(() => completed = true)
                .Bind(x => Debug.Log(x));

            while (!completed) yield return null;
        }
    }
}