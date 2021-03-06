# ComplipoundingInterest
A problem where Interest has to be compounded and calculated based on custom rules including credit and debit

Com(plicating)pounding My Interest

Murugesh has started a Savings account in a new bank 'LeaseGoWave'. The bank applies compound interest for the money that you put into it as principal. Compound interest is a special type of interest where the interest is calculated on the previous term's principal+interest amount. 

Interest = (Principal * Term * Rate)/100
[Here, term is taken as 1 as we are calculating compund interest and we manually calculate interest up the full amount monthly]

Example: 
Principal is Rs.1000
Rate is 5 %
Term is 3 months


1st month

Interest = (Principal * 1 * Rate)/100 
Interest = 50
Amount at end of 1st month = Principal + Interest
Amount = Rs.1050

For the 2nd month, the amount of the 1st month becomes the principal

Interest = (Principal * 1 * Rate)/100 
Interest = (1050 * 5)/100
Interest = 52.5
Amount = 1050 + 52.5 = Rs.1102.50

For the 3rd month, the amount of the 2nd month becomes the principal


Interest = (1102.50 * 5)/100
Interest = 55.125 which is rounded to 2 digits as 55.13 (If 3rd decimal is 5 or greater, then it is rounded up, else rounded down)
Amount = 1102.50 + 55.13 = Rs.1157.63

So, the final amount that we get is Rs.1157.63
This is the mechanism of compound interest.

However, LeaseGoWave Bank has some special plans to benefit Murugesh.

For every 4 months, after compounding for that month, the bank reduces 1/8th of the Amount to the current Principal amount. i.e., if the amount after 4 months is Rs.800, bank takes away 1/8th of it i.e., Rs.100 and Customer is left with Rs.700 which is used as the Principal amount for the next month (5th month).

For every 6 months, before compounding for the month, the bank adds 1/3rd of the Amount to the current Principal amount. i.e., if the amount after 6 months is Rs.150, bank adds 1/3rd of it i.e., Rs.50 and the Customer now has Rs. Rs.200 which is used as the Principal for compounding for that month. 

In months common to both reduction and addition to Principal (like the 12th month), both reduction and additions are done (following the existing rules of whether it is done before compounding or after compounding)

Additionally, after every 15 months, the rate is reduced by 0.75
If, when we are reducing it, the rate becomes 0 or goes to negative, we manually set the rate as 0.2 for the subsequent months.
10 months after we have manually made the rate to 0.2, the rate reduces to 0.1 permanently. 

Every Interest calculation, the Interest is rounded to 2 decimals.
Every amount calculation of Interest + Principal is rounded to 2 decimals.
The final Amount is rounded to 2 decimals.
In rounding, if 3rd decimal is 5 or greater, then it is rounded up, else rounded down.

Murugesh is giving the Principal amount and the term. The bank is giving the initial Rate of Interest.

We, as the masterminds of the LeaseGoWave bank should calculate the final amount which Murugesh would receive at the end of the term.

Input:
3 lines of input. 
First line should accept a positive decimal value of Principal
Second line should accept a positive decimal value of Rate
Third line should accept a positive int value of Term

Output:
1 line of decimal output Amount

Example 1
Sample Input:
1000
5
3

Sample Output
1157.63

Example 2
Sample Input:
65000
2.10
32

Sample Output
159077.89

Example 3
Sample Input:
65000
1.25
32

Sample Output
122694.06

Example 4
Sample Input:
65000
1.84
60

Sample Output
259883.93
