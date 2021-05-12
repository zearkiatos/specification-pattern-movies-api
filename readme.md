#Public pages
- heroku: http://sp-movies-api.herokuapp.com

#Publish in Heroku

**Step 1:**
- Create a docker image
docker build . -f heroku.dockerfile -t sp-movies-api

**Step 2**
- Login in heroku
heroku login

**Step 3**
- Push Application in heroku
heroku container:push web --app sp-movies-api

**Step 4**
- Note: If this step not found continue to step 2, if this step is ok pass to step seven
- Publish application
 heroku container:release web --app sp-movies-api

 **Step 5**
- Create a tag in docker
docker tag sp-movies-api registry.heroku.com/sp-movies-api/web

**Step 6**
- Push image in Heroku
docker push registry.heroku.com/sp-movies-api/web

**Step 7**
- Release the application in heroku
 heroku container:release web --app=sp-movies-api

