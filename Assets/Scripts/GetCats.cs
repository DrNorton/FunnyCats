using System.Linq;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetCats : MonoBehaviour {
    private Image _image;
    private Sprite[] _cats;
    private int _currentIndex = 0;

    // Use this for initialization
	void Start ()
	{
	   _image=this.GetComponent<Image>();
	   _cats=Resources.LoadAll<Sprite>("cats");
	    SetCatImage();
	}

    private void SetCatImage()
    {
        _image.sprite = _cats.ElementAt(_currentIndex);
    }

    // Update is called once per frame
	void Update () {
	    
	}

    public void NextCat()
    {
        if (_currentIndex == _cats.Length-1)
        {
            _currentIndex = -1;
        }
        _currentIndex++;
        SetCatImage();
    }
}
