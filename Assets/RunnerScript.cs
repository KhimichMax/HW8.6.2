using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerScript : MonoBehaviour
{
    [SerializeField] private Transform[] _arrRunner;
    private Transform _currentRunner;
    private Transform _nextRunner;
    private int _runnerIndex = 0;
    private float _distance;
    private float _passDistance = 1.2f;
    private bool flag;
    
    private void CycleRunnerRun()
    {
        _distance = Vector3.Distance(_currentRunner.position, _nextRunner.position);
        if (_distance <= _passDistance)
        {
            _runnerIndex++;
            if (_runnerIndex >= _arrRunner.Length)
            {
                _runnerIndex = 0;
            }
            _currentRunner = _nextRunner;
            _nextRunner = _arrRunner[_runnerIndex];
        }
    }
    
    void Start()
    {
        _currentRunner = _arrRunner[0];
        _runnerIndex += 1;
        _nextRunner = _arrRunner[_runnerIndex];
    }

    
    void Update()
    {
        _currentRunner.position = Vector3.MoveTowards(_currentRunner.position, _nextRunner.position, Time.deltaTime);
        CycleRunnerRun();
    }
}
