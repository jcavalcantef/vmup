using UnityEngine;

public class Graph : MonoBehaviour {

	public Transform     pointPrefab;
	public static int    resolution = 1000;  //Quantity of points used to plot graphic
    public static float  step       = 0.05f; //Graph width
    Vector3              scale      = Vector3.one * step;
    Vector3              position;
    Transform            []points;
    SquareWave           squareWave;

    void Awake ()
    {
		position.y = 0f;
		position.z = 0f;
		points     = new Transform[resolution];
        squareWave = new SquareWave(0,2,0.2f);

		for (int i = 0; i < points.Length; i++)
        {
			Transform point     = Instantiate(pointPrefab);
			position.x          = (i + 0.2f) * step - 1f;
			point.localPosition = position;
			point.localScale    = scale;
			point.SetParent(transform, false);
			points[i]          = point;
		}
	}

	void Update ()
    {
		for (int i = 0; i < points.Length; i++)
        {
			Transform point     = points[i];
			Vector3 position    = point.localPosition;
            position.y          = squareWave.PlotSquareWave(position.x + Time.time);
            point.localPosition = position;
		}
	}
}