using UnityEngine;

namespace Variables
{
    public class C04_QuizGrades : MonoBehaviour
    {
        // Calculate 5 random quiz grades and print them out

        // Array for the quiz grades
        // for loop to print them out

        [SerializeField] private int[] _quizGrades;

        private void Start()
        {
            for (var i = 0; i < _quizGrades.Length; i++)
            {
                _quizGrades[i] = Random.Range(0, 101);
                Debug.Log(_quizGrades[i]);
            }
        }
    }
}