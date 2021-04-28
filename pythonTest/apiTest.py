
import requests

class testingAPI:

    #def __init__(self, link):
    #    self.link = ''


    def fetchAPI(self, link):
        with requests.session() as f:
            jsn = f.get(link, verify=False)
            data = jsn.json()

            return data




if __name__ == '__main__':
    api = testingAPI()
    dataapi = api.fetchAPI('https://localhost:5001/api/MangaAPI/search?mangaName=testjmeno')

    print(dataapi)

    print(dataapi["jmeno"])
    print(dataapi["prijmeni"])
    print(dataapi["veci"]["nazev"])
