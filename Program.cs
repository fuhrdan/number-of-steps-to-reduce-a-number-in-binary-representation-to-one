//******************************************************************************
//** 1404. Number of Steps to Reduce a Number in Binary Representation to One **
//******************************************************************************
//** From right to left the bits we tread,
//** A quiet carry softly spread.
//** When ones demand we add, then shift
//** Till one remains, our final gift.
//******************************************************************************

int numSteps(char* s)
{
    int ans = 0;
    bool carry = false;
    int len = strlen(s);
    int i;
    char c;

    for (i = len - 1; i > 0; i--)
    {
        c = s[i];

        if (carry)
        {
            if (c == '0')
            {
                c = '1';
                carry = false;
            }
            else
            {
                c = '0';
            }
        }

        if (c == '1')
        {
            ans++;
            carry = true;
        }

        ans++;
    }

    if (carry)
    {
        ans++;
    }

    return ans;
}