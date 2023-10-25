#include <stdio.h>
#include <stdlib.h>
struct ListNode {
    int data;
    struct ListNode* next;
};

struct ListNode* reverseList(struct ListNode* head)
{
    /*
    if(head == NULL || head->next == NULL)
    {
        return head;
    }
    struct ListNode* pnode=(struct ListNode*)malloc(sizeof(struct ListNode));
    pnode->data = head->data;
    pnode->next = NULL;
    head = head->next;
    */

    // leetcode is confusing when it comes to testing problems like this...
    // the above is pointless.
    // even though in a real environment you would need to allocate space.
    
    struct ListNode* pnode = NULL;
    while(head != NULL)
    {
        struct ListNode* current_node = pnode;
        pnode = head;
        head = head->next;
        pnode->next = current_node;
    }
    return pnode;
}

int main()
{

    return 0;
}