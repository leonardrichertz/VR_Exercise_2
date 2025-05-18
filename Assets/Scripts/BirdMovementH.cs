using UnityEngine;

public class BirdMovementH : MonoBehaviour
{

    // If the bird is faster, the game is easier
    // If the bird is slower, the game is harder
    [SerializeField] float birdSpeed = 2f;

    Vector3 targetTreePosition;
    GameObject targetTree;

    TreeSpawner treeSpawner;

    private bool selectedTree;

    void Start()
    {
        if (treeSpawner == null)
        {
            treeSpawner = FindObjectOfType<TreeSpawner>();
        }
    }

    void Update()
    {
          if (targetTree != null)
        {
            MoveBirdToTree();
        }
    }

    // New method to set the target tree from the pointer
    public void SetTargetTree(GameObject tree)
    {
        if (tree != null)
        {
            targetTree = tree;
            targetTreePosition = tree.transform.position;
            targetTreePosition.y = 3; // Adjust height for bird flight
            
            // Mark the tree as chosen by the bird
            TreeLifecycle treeLifecycle = tree.GetComponent<TreeLifecycle>();
            if (treeLifecycle != null)
            {
                treeLifecycle.birdChoseThisTree = true;
                MoveBirdToTree();
            }
        }
    }

    // Clear the selected tree.
    public void ClearTargetTree()
    {
        targetTree = null;
        targetTreePosition = Vector3.zero;
    }

    void MoveBirdToTree()
    {
        // Move the bird towards the target tree, if it is not already close enough
        if (Vector3.Distance(transform.position, targetTreePosition) >= 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetTreePosition, birdSpeed * Time.deltaTime);
            transform.LookAt(targetTreePosition);
        }
        else
        {
            // Fly around the tree if we are close enough
            transform.RotateAround(targetTreePosition, Vector3.up, birdSpeed * 5 * Time.deltaTime);
            transform.LookAt(targetTreePosition);
        }
    }
}
