using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerScript : MonoBehaviour
{
    [SerializeField] private Transform _firstCube;
    [SerializeField] private Transform _secondCube;
    [SerializeField] private Transform _thirdCube;
    private Vector3 _targetRuner;
    private float _passDistance;
    private List<Transform> _arrRunner;

    private void AddRunner()
    {
        _arrRunner.Add(_firstCube);
        _arrRunner.Add(_secondCube);
        _arrRunner.Add(_thirdCube);
    }

    private void CycleRunnerRun()
    {
        _firstCube.position = Vector3.MoveTowards(_firstCube.position, _targetRuner, Time.deltaTime);

        for (int i = 0; i < _arrRunner.Count; i++)
        {
            if (_targetRuner == _arrRunner[i].position)
            {
                _targetRuner = _arrRunner[i + 1].position;
            }
        }
    }
    
    void Start()
    {
        AddRunner();
        _targetRuner = _firstCube.position;
    }

    
    void Update()
    {
        
    }
}
