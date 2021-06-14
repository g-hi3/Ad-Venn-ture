using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {

  private static readonly int AnimatorPropertyIsOpen = Animator.StringToHash("IsOpen");
  [SerializeField] private AudioClip _openClip;
  [SerializeField] private AudioClip _closeClip;
  private Collider2D _collider;
  private Animator _animator;
  private AudioSource _audioSource;
  private Coroutine _activeCoroutine;

  public void Open() {
    if (_activeCoroutine != null) {
      return;
    }
    _collider.enabled = false;
    _animator.SetBool(AnimatorPropertyIsOpen, true);
    _audioSource.clip = _openClip;
    _audioSource.Play();
    _activeCoroutine = StartCoroutine(AwaitClosing());
  }

  private IEnumerator<WaitForSeconds> AwaitClosing() {
    yield return new WaitForSeconds(1);
    Close();
  }

  private void  Close() {
    _collider.enabled = true;
    _animator.SetBool(AnimatorPropertyIsOpen, false);
    _audioSource.clip = _closeClip;
    _audioSource.Play();
    _activeCoroutine = null;
  }

  private void Awake() {
    _collider = GetComponent<Collider2D>();
    _animator = GetComponent<Animator>();
    _audioSource = GetComponent<AudioSource>();
  }

}
