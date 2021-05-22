// Complete the triplets function below.
// https://www.hackerrank.com/challenges/triple-sum/problem
debugger
function triplets(a, b, c) {

  if(!a.length || !b.length || !c.length) {
    return 0;
  }

  a = a.sort((a,b) => a-b);
  b = b.sort((a,b) => a-b);
  c = c.sort((a,b) => a-b);

  a = Array.from((new Set([...a]).keys()));
  b = Array.from((new Set([...b]).keys()));
  c = Array.from((new Set([...c]).keys()));
  let count = 0;
  let times1 = 0;
  let times2 = 0;
  let aIndex = 0;
  let cIndex = 0;

  for(let bNum of b) {
    for(; aIndex<a.length; aIndex++) {
      if(bNum>=a[aIndex]) times1++;
      else break;
    }

    for(; cIndex<c.length; cIndex++) {
      if(bNum>=c[cIndex]) times2++;
      else break;
    }

    count += times1*times2;
  }

  return count;

}

// triplets([ 1, 3, 5, 7 ], [ 5, 7, 9 ], [ 7, 9, 11, 13 ]);


//9593177511025