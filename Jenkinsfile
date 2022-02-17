pipeline {
    agent any
    // triggers {
    //     cron('H */4 * * 1-5')
    // }
    options {
        timeout(time: 1, unit: 'HOURS') 
        timestamps()
    }
    environment {
        USER_NAME = 'Sagor'
        dotnet ='C:\\Program Files (x86)\\dotnet\\'
    }
    stages {
        stage('Example') {
            steps {
                echo 'Hello World'
                echo $(USER_NAME)
            }
        }
        stage('Donet Clean') {
            steps {
               bat 'dotnet clean'
            }
        }

        stage('Donet Restore') {
            steps {
               bat 'dotnet restore'
            }
        }
        
        stage('Donet Build') {
            steps {
               bat 'dotnet build'
            }
        }
    }

    post {	// When the Pipeline has finished executing, you may need to run clean-up steps or perform some actions based on the outcome of the Pipeline.
        always {
            echo 'This will always run'
            echo "${currentBuild.currentResult}: Job   ${env.JOB_NAME} build ${env.BUILD_NUMBER}\n More info at: ${env.BUILD_URL}"
            echo "Jenkins Build ${currentBuild.currentResult}: Job ${env.JOB_NAME}"
        }
        success {
            echo 'This will run only if successful'
            echo 'Email notification by Email Extension'
            // emailext body: "${currentBuild.currentResult}: Job   ${env.JOB_NAME} build ${env.BUILD_NUMBER}\n More info at: ${env.BUILD_URL}",
            //     recipientProviders: [developers(), requestor()],
            //     subject: "Success Pipeline: ${currentBuild.fullDisplayName}",
            //     to: 'mdtaslim1@yahoo.com'
        }
        failure {
            echo 'This will run only if failed'
			// mail 	to: 'mdtaslim1@yahoo.com',
			// 		subject: "Failed Pipeline: ${currentBuild.fullDisplayName}",
			// 		body: "Something is wrong with ${env.BUILD_URL}"
        }
        unstable {
            echo 'This will run only if the run was marked as unstable'
        }
        changed {
            echo 'This will run only if the state of the Pipeline has changed'
            echo 'For example, if the Pipeline was previously failing but is now successful'
        }
    }
    
}