using UnityEngine;
using System.Collections;

public class CSceneMap : MonoBehaviour {
    public GameObject Flat;
    // Use this for initialization
    void Start () {
        m_flatData = new int[20, 10];
        m_flats = new GameObject[20, 10];
        gameObject.transform.localPosition = new Vector3(0, 0, 0);
        /*
       // ArrayList changePosList = new ArrayList();
        //for (int j = (int)(0); j < 1; j++) {
        //    for (int i = (int)(0); i < 1; i++) {
        //        changePosList.Add(new Vector2(j, i));
        //    }
        //}
       // _updateMap(changePosList);
    */
    }

    // Update is called once per frame
    void Update () {
  
    }

    private int[] m_temp = new int[20];
    private GameObject[] m_tempFlat = new GameObject[20];
    public void Move(bool isLeft) {
        if (isLeft) {
            // data
            for (int i = 0; i < 20; i++) {
                m_temp[i] = m_flatData[i, 0];
            }
            for (int i = 0; i < 20; i++) {
                for (int j = 1; j < 10; j++) {
                    m_flatData[i, j-1] = m_flatData[i, j];
                }
            }
            for (int i = 0; i < 20; i++) {
                m_flatData[i, 10-1] = m_temp[i];
            }

            // flat
            for (int i = 0; i < 20; i++) {
                m_tempFlat[i] = m_flats[i, 0];
            }
            for (int i = 0; i < 20; i++) {
                for (int j = 1; j < 10; j++) {
                    m_flats[i, j - 1] = m_flats[i, j];
                    if (m_flats[i, j - 1])  m_flats[i, j - 1].transform.Translate(-CFlats.SIZE, 0, 0);
                }
            }
            for (int i = 0; i < 20; i++) {
                m_flats[i, 10 - 1] = m_tempFlat[i];
                if (m_flats[i, 10 - 1])  m_flats[i, 10 - 1].transform.Translate((10-1)*CFlats.SIZE, 0, 0);
            }
        } else {
            for (int i = 0; i < 20; i++) {
                m_temp[i] = m_flatData[i, 10-1];
            }
            for (int i = 0; i < 20; i++) {
                for (int j = 10-2; j >= 0; j--) {
                    m_flatData[i, j + 1] = m_flatData[i, j];
                }
            }
            for (int i = 0; i < 20; i++) {
                m_flatData[i, 0] = m_temp[i];
            }

            // flat
            for (int i = 0; i < 20; i++) {
                m_tempFlat[i] = m_flats[i, 10 - 1];
            }
            for (int i = 0; i < 20; i++) {
                for (int j = 10 - 2; j >= 0; j--) {
                    m_flats[i, j + 1] = m_flats[i, j];
                    if (m_flats[i, j + 1]) m_flats[i, j + 1].transform.Translate(CFlats.SIZE, 0, 0);
                }
            }
            for (int i = 0; i < 20; i++) {
                m_flats[i, 0] = m_tempFlat[i];
                if (m_flats[i, 0]) m_flats[i, 0].transform.Translate(-(10 - 1) * CFlats.SIZE, 0, 0);
            }
        }
    }
    public bool IsFlatsCrossMap(GameObject flats) {
        Vector3 flatPos = flats.transform.localPosition;
        int startI = (int)((flatPos.y) / CFlats.SIZE);
        int startJ = (int)(flatPos.x / CFlats.SIZE);
        CFlats flatsScript = flats.GetComponent<CFlats>();
        int[,] flatsData = flatsScript.GetData();
        
        // check next, if nextData is Cross, then is End
        bool isCross = _IsCross(startI - 1, startJ, flatsData); // 还需要检查当前格
        if (isCross) {
            // cross
            // if (flatsData == null) print("data is null");
            _SetData(startI, startJ, flatsData);
            return true;
        }

        return false;
    }

    private void _SetData(int startI, int startJ, int[,] data) {
        ArrayList changePosList = _GetCrossData(startI, startJ, data);
        //int startX = (int)(startPos.x);
        //int startY = (int)(startPos.y);
        //foreach (Vector2 pos in changePosList) {
        //    m_flatData[startY+(int)pos.y, startX+ (int)pos.x] = data[(int)(pos.y), (int)(pos.x)];
        //}
        _updateMap(changePosList);
    }

    private bool _IsCross(int startI, int startJ, int[,] data) {
        ArrayList changePosList = new ArrayList();
        int baseI = 0;
        int baseJ = 0;
        for (int j = startJ; j < 4 + startJ; j++) {
            baseJ = j - startJ;
            for (int i = startI - 3; i <= startI; i++) {
                baseI = i - (startI - 3);
                if (i < 0) {
                    // 到边界了
                    print("边界");
                    return true;
                } else {
                    
                    if (data[baseI, baseJ] != 0 && data[baseI, baseJ] == m_flatData[i, j]) {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    private ArrayList _GetCrossData(int startI, int startJ, int[,] data) {
        ArrayList changePosList = new ArrayList();
        // print("data ' s value " + data);
        int baseI = 0;
        int baseJ = 0;
        for (int j = startJ; j < 4 + startJ; j++) {
            baseJ = j - startJ;
            for (int i = startI - 3; i <= startI; i++) {
                baseI = i - (startI - 3);
                if (i < 0) {
                    // 到边界了
                } else {
                     //print("i : " + i + ", j : " + j);
                     //print("baseI : " + baseI + ", baseJ : " + baseJ);
                    
                    //print("m_flatData " + m_flatData[i, j]);
                    //print("data " + data[baseI, baseJ]);
                    if (data[baseI, baseJ] != 0 && data[baseI, baseJ] > m_flatData[i, j]) {
                        m_flatData[i, j] = data[baseI, baseJ];
                        changePosList.Add(new Vector2(j, i));
                    }
                }
            }
        }
        return changePosList;
    }

    private void _updateMap(ArrayList changePosList) {
        GameObject flat;
        foreach (Vector2 pos in changePosList) {
            flat = Instantiate(Flat);
            flat.transform.parent = gameObject.transform;
            flat.transform.localPosition = new Vector3(CFlats.SIZE * pos.x, CFlats.SIZE * pos.y, 0);
            m_flats[(int)pos.y, (int)pos.x] = flat;
        }
    }

    private int[,] m_flatData;
    private GameObject[,] m_flats;

}
