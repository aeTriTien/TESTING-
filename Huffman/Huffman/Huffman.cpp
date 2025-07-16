#include <iostream>
#include <map>
#include <string>
#include <fstream>
#include <queue>
using namespace std;
struct HuffmanTreeNode
{
	char val;
	int freq;
	HuffmanTreeNode* left;
	HuffmanTreeNode* right;

	HuffmanTreeNode(char v, int f) : val(v), freq(f), left(NULL), right(NULL) {};
	HuffmanTreeNode(HuffmanTreeNode* l, HuffmanTreeNode* r) : val('\0'), freq(l->freq + r->freq), left(l), right(r) {};
};

struct Compare {
	bool operator()(HuffmanTreeNode* a, HuffmanTreeNode* b)
	{
		return a->freq > b->freq;
	}
};
string append(string filename);
map<char, int> count_freqs(string str);
string DeCode(string code, map<char, string> Codemap);
string Encode(string str, map<char, string>Codemap);
void BuildCodeMap(HuffmanTreeNode* root, string code, map<char, string>& Codemap);
HuffmanTreeNode* BuildHuffmanTree(map<char, int> charc);


//void PrintHelpAndExit()
//{
//	cout << "zap [zip|unzip] inputFile outputFile\n";
//	exit(EXIT_FAILURE);
//}
/*
	Tư tưởng của Encode
	B1: Đọc file, lưu các chuỗi trong file thành 1 chuỗi để dễ xử lý

	B2: Đếm tần xuất của từng kí tự và lưu vào map<char, int>charc

	B3: Từ tần xuất map<char, int>charc có được ta xây dựng struct compare bằng cách so sánh tần xuất -> dùng để xây dựng priority_queue
	B4: BuildHuffmanTree (đưa map<char, int> charc vào priority_queue)

	B5: Từ BuildHuffmanTree tạo được Codemap

	B6: EnCode = CodeMap
	B7: DeCode = CodeMap
*/
int main() {
	string filename = "Chuoi.INP";

	string chuoi = append(filename);
	map<char, int> list = count_freqs(chuoi);

	HuffmanTreeNode* root = BuildHuffmanTree(list);

	map<char, string> Codemap;
	string code;
	BuildCodeMap(root, code, Codemap);

	string fileEncode = "Encode.txt";
	ofstream fo(fileEncode);

	string Mahoa = Encode(chuoi, Codemap);
	fo << Mahoa;

	ifstream fi(fileEncode);
	fi >> Mahoa;

	string Chuoihoa = DeCode(Mahoa, Codemap);
	string fileDecode = "Decode.txt";
	ofstream fout(fileDecode);
	fout << Chuoihoa;
}
/*int main(int argc, char** argv)
{

	if (argc < 4)
		PrintHelpAndExit();

	// mo a
	// mo b
	// doc a

	if (strcmp(argv[1], "zip") == 0)
	{
		// enc a
	}
	else if (strcmp(argv[1], "unzip") == 0)
	{
		// denc a
	}
	else
		PrintHelpAndExit();

	// wrt b

	return EXIT_SUCCESS;
}
*/
HuffmanTreeNode* BuildHuffmanTree(map<char, int> charc)
{
	priority_queue<HuffmanTreeNode*, vector<HuffmanTreeNode*>, Compare>que;
	for (auto pair : charc)
	{
		que.push(new HuffmanTreeNode(pair.first, pair.second));
	}
	while (que.size() > 1)
	{
		HuffmanTreeNode* l = que.top();
		que.pop();
		HuffmanTreeNode* r = que.top();
		que.pop();
		HuffmanTreeNode* merge = new HuffmanTreeNode(l, r);
		que.push(merge);
	}
	return que.top();
}

void BuildCodeMap(HuffmanTreeNode* root, string code, map<char, string>& Codemap)
{
	if (root == NULL)
		return;
	if (root->val != '\0')
	{
		Codemap[root->val] = code;
	}
	BuildCodeMap(root->left, code + "0", Codemap);
	BuildCodeMap(root->right, code + "1", Codemap);
}

string Encode(string str, map<char, string>Codemap)
{
	string code;
	string temp;
	for (int i = 0; i < str.length(); i++)
	{
		code += Codemap[str[i]];
	}
	return code;
}

string DeCode(string code, map<char, string> Codemap)
{
	string result;
	string temp;
	for (int i = 0; i < code.length(); i++)
	{
		temp = temp + code[i];
		for (auto pair : Codemap)
		{
			if (temp == pair.second) {
				result = result + pair.first;
				temp = "";
			}
		}
	}
	return result;
}
map<char, int> count_freqs(string str)
{
	map<char, int> charc;
	for (char c : str)
		charc[c]++;
	charc['\n']--;
	return charc;
}

string append(string filename)
{
	ifstream fi(filename);

	if (!fi.is_open())
	{
		cout << "Khong the mo file.\n";
		return "";
	}
	string line;
	string str;
	while (getline(fi, line)) {
		str += line + '\n';
	}
	return str;
}