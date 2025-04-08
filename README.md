# Photo Album MVC

Photo Album MVC is a project that implements a photo album application following the Model-View-Controller (MVC) architectural pattern. This structure separates the application's data (Model), user interface (View), and business logic (Controller) to promote organized and modular code.

## Features

- **User Authentication:** Users can create accounts, log in, and manage their photo albums securely.
- **Album Management:** Create, rename, and delete photo albums.
- **Photo Handling:** Add, remove, and view photos within albums.
- **Tagging System:** Assign tags to photos for easy categorization and search.
- **Search Functionality:** Search for photos based on tags or other metadata.
- **Photo Sharing:** Share albums or individual photos with other users.
- **Responsive UI:** A user-friendly interface that adapts to various screen sizes.

## Technologies Used

- **Backend:** ASP.NET Core for handling server-side operations and API endpoints.
- **Frontend:** Razor Pages for dynamic web content and responsive design.
- **Database:** SQL Server for storing user data, albums, and photo metadata.
- **Authentication:** ASP.NET Identity for managing user accounts and authentication.

## Installation

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/SirTebz/Photo-Album-MVC.git
   ```


2. **Navigate to the Project Directory:**
   ```bash
   cd Photo-Album-MVC
   ```


3. **Set Up the Database:**
   - Ensure SQL Server is installed and running.
   - Update the connection string in `appsettings.json` to match your database configuration.
   - Apply migrations to set up the database schema:
     ```bash
     dotnet ef database update
     ```

4. **Run the Application:**
   ```bash
   dotnet run
   ```

   The application will start, and you can access it in your web browser at `https://localhost:5001`.

## Usage

- **Register an Account:** Create a new user account to start using the application.
- **Create Albums:** Navigate to the "Albums" section to create new photo albums.
- **Upload Photos:** Within an album, use the "Add Photo" feature to upload images.
- **Manage Tags:** Assign tags to your photos to categorize them effectively.
- **Search Photos:** Use the search functionality to find photos by tags or other criteria.
- **Share Content:** Share your albums or individual photos with other registered users.

## Contributing

Contributions are welcome! To contribute:

1. **Fork the Repository:** Click the "Fork" button at the top right of the repository page.
2. **Clone Your Fork:**
   ```bash
   git clone https://github.com/your-username/Photo-Album-MVC.git
   ```

3. **Create a New Branch:**
   ```bash
   git checkout -b feature/your-feature-name
   ```

4. **Make Your Changes:** Implement your feature or fix.
5. **Commit Changes:**
   ```bash
   git commit -m "Description of your changes"
   ```

6. **Push to Your Fork:**
   ```bash
   git push origin feature/your-feature-name
   ```

7. **Submit a Pull Request:** Go to the original repository and click "New Pull Request."

## License

This project is licensed under the MIT License. See the `LICENSE.txt` file for details.

## Acknowledgments

Special thanks to all contributors and the open-source community for their invaluable support and resources. 
