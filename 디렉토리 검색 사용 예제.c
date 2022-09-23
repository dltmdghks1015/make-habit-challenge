// 단순 출력한다.
void myfunc(char *file)
{
    print("--> %s\n", file);
}

int main()
{
    // home디렉토리에 있는 모든 파일과 그 하부디렉토리의 파일을
    // 검색한후 myfunc를 호출해서 단순 출력한다.
    /*
	cwd : 검색하고자 하는 경로명
	func : 함수 포인터, 인자는 파일이름이 주어진다.
	depth : 디렉토리 검색 깊이. 0이면 모든 하위디렉토리를 전부 검색, 0보다 크면 해당 인수의 깊이 만큼만 검색
	*/
    Scandir("/home", myfunc, 0);
}
