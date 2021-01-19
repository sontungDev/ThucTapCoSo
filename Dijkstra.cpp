#include <stdio.h>
#define CHUA 0
#define ROI 1
#define VC 1000000
#define MAX 100
int n; // so dinh
int m; // so canh
int s; // dinh bat dau
int t; // dinh ket thuc
int nhan[MAX]; // mang dung de gan nhan
int kc[MAX]; // mang luu tru khoang cach
int mt[MAX][MAX]; // ma tran trong so
int xet[MAX]; // mang luu tru cac dinh da xet hay chua

void DocFile()
{
	int tam[100][100];
	FILE *fp = fopen("input.txt","r");
	fscanf(fp,"%d%d%d%d",&n,&m,&s,&t);
	for(int i=1;i<=m;i++)
		for(int j=1;j<=3;j++)
			fscanf(fp,"%d",&tam[i][j]);

		for(int i=1;i<=n;i++)
			for(int j=1;j<=n;j++)
				mt[i][j]=VC;
		
		for(int i=1;i<=m;i++)
		{
			mt[tam[i][1]][tam[i][2]]=tam[i][3];
			mt[tam[i][2]][tam[i][1]]=tam[i][3];	
		}	
	fclose(fp);
}
void GhiFile()
{
	FILE *fp = fopen("output.txt","w");
	int i=nhan[t];
	int tam[100];
	int sodinh=2;
	while(i!=s)
	{
		tam[sodinh]=i;
		i=nhan[i];
		sodinh++;
	}
	fprintf(fp,"%d %d\n",sodinh,kc[t]);
	fprintf(fp,"%d ",s);
	for(int j=sodinh-1;j>=2;j--)
	{
		fprintf(fp,"%d ",tam[j]);
	}
	fprintf(fp,"%d",t);
	fclose(fp);
}
void Dijkstra()
{
	int i, min;
	for(int j=1;j<=n;j++)
	{
		kc[j]=mt[s][j];
		nhan[j]=s;
		xet[j]=CHUA;
	}
	nhan[s]=0;
	kc[s]=0;
	xet[s]=ROI;
	while(!xet[t])
	{
		min=VC;
		for(int j=1;j<=n;j++)
		{
			if(!xet[j] && min > kc[j])
			{
				i=j; // lay dinh co khoang cach nho nhat
				min=kc[j]; // khoang cach nho nhat
			}
		}
		xet[i]=ROI;
		if(!xet[t])
		{
			for(int j=1;j<=n;j++)
			{
				if(!xet[j] && (kc[i] + mt[i][j] < kc[j])) // kc dinh nho nhat + kc tu dinh i den j
				{										
					kc[j] = kc[i] + mt[i][j];
					nhan[j] = i;
				}
			}
		}
	}
}
int main()
{
	DocFile();
	Dijkstra();
	GhiFile();
	return 0;
}

