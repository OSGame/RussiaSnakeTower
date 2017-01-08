using UnityEngine;
using System.Collections;

public class CFlats : MonoBehaviour {
    public GameObject Flat;

    // Use this for initialization
    void Start() {
        m_isInitial = false;
        _Build();
        // print("flats is Start");
    }

    // Update is called once per frame
    void Update() {

    }

    public int[,] GetData() {
        return m_datas;
    }

    public bool IsInitial() {
        return m_isInitial;
    }
    private void _Build() {
        m_datas = _createDatas();
        m_isInitial = true;
        
        GameObject tempFlat;
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                int value = m_datas[i, j];
                if (value != 0) {
                    tempFlat = Instantiate(Flat);
                    tempFlat.transform.SetParent(this.gameObject.transform);
                    tempFlat.transform.localPosition = new Vector3(j* SIZE, i* SIZE, 0);
                }
            }
        }
    }

    private int[,] _createDatas() {
        int rndK = Random.Range(0, 8);
        int[,] ret = new int[4, 4];
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                ret[i, j] = _TYPE_[rndK, i, j];
            }
        }
        return ret;
    }

    private static int[,,] _TYPE_ = { 
        {
            {0, 0, 0, 0}, 
            {0, 0, 0, 0},
            {0, 1, 1, 0},
            {0, 1, 1, 0},
        },
        {
            {0, 0, 1, 0},
            {0, 0, 1, 0},
            {0, 0, 1, 0},
            {0, 0, 1, 0},
        },
        {
            {0, 0, 0, 0},
            {0, 1, 0, 0},
            {0, 1, 1, 0},
            {0, 0, 1, 0},
        },
        {
            {0, 0, 0, 0},
            {0, 1, 0, 0},
            {0, 1, 1, 0},
            {0, 0, 1, 0},
        },
        {
            {0, 0, 0, 0},
            {0, 0, 1, 0},
            {0, 1, 1, 0},
            {0, 1, 0, 0},
        },
        {
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 1, 0},
            {0, 1, 1, 1},
        },
        {
            {0, 0, 0, 0},
            {0, 1, 1, 0},
            {0, 1, 0, 0},
            {0, 1, 0, 0},
        },
        {
            {0, 0, 0, 0},
            {0, 1, 1, 0},
            {0, 0, 1, 0},
            {0, 0, 1, 0},
        }
    };

    // type 方块, 直条1,2, 7字1，2 折1,2 土
    private int[,] m_datas;
    private bool m_isInitial;

    public static int SIZE = 15;
}
