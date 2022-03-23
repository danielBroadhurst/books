const createKnexClient = require('./knex-client');
const createHomeApp = require('./app/home');


function createConfig({env}) {
  console.log(env.databaseUrl);
  const db = createKnexClient({
    connectionString: env.databaseUrl
  })
  const homeApp = createHomeApp({ db })
  return {
    env,
    db, 
    homeApp
  }
}

module.exports = createConfig;